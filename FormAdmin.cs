using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OtelOtomasyonu.LogicLayer;

namespace OtelOtomasyonu
{
    public partial class FormAdmin : Form
    {
        private readonly RoomManager _roomBLL = new RoomManager();
        private List<Tuple<int, string>> _rooms = new List<Tuple<int, string>>();
        private PaymentManager _paymentManager;

        public FormAdmin()
        {
            InitializeComponent();
            _roomBLL = new RoomManager();
            _rooms = new List<Tuple<int, string>>();
            _paymentManager = new PaymentManager();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRoomData();
                LoadRoomTypes();
                LoadPaymentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadRoomData()
        {
            _rooms = _roomBLL.GetRooms();
            if (_rooms.Count == 0)
                MessageBox.Show("Oda Bulunamadı!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadRoomTypes()
        {
            var roomTypes = _roomBLL.GetRoomTypes();
            roomAddCombobox.Items.Clear();
            roomTypeCombobox.Items.Clear();

            foreach (var type in roomTypes)
            {
                roomAddCombobox.Items.Add(type);
                roomTypeCombobox.Items.Add(type);
            }
            roomAddCombobox.SelectedIndex = -1;
            roomTypeCombobox.SelectedIndex = -1;
        }
        private void LoadPaymentData()
        {
            try
            {
                DataTable paymentData = _paymentManager.GetAllPayments();

                paymentDataGrid.DataSource = paymentData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura verileri yüklenirken bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearRoomFields()
        {
            roomAddTxt.Clear();
            roomLayoutTxt.Clear();
            roomChangeTxt.Clear();
            roomDeleteTxt.Text = string.Empty;
        }
        private void roomTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomTypeCombobox.SelectedItem != null)
            {
                string selectedRoomType = roomTypeCombobox.SelectedItem.ToString();
                var filteredRooms = _rooms.Where(r => r.Item2 == selectedRoomType).Select(r => r.Item1).ToList();

                roomNumberCombobox.Items.Clear();
                foreach (var roomId in filteredRooms)
                {
                    roomNumberCombobox.Items.Add(roomId);
                }

                if (filteredRooms.Any())
                {
                    roomNumberCombobox.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Seçili oda tipi için oda numarası bulunamadı.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearRoomFields();
                }
            }
        }
        private void roomNumberCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomNumberCombobox.SelectedItem != null)
            {
                string selectedRoomId = roomNumberCombobox.SelectedItem.ToString();
                roomLayoutTxt.Text = selectedRoomId;
                roomDeleteTxt.Text = selectedRoomId;
                roomChangeTxt.Text = selectedRoomId;
            }
        }
        private void roomAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int roomId = int.Parse(roomAddTxt.Text);
                string roomType = roomAddCombobox.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(roomType))
                {
                    MessageBox.Show("Oda tipi seçilmelidir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Dictionary<string, int> roomPrices = _roomBLL.GetRoomPrices();
                if (!roomPrices.ContainsKey(roomType))
                {
                    MessageBox.Show("Seçilen oda tipi için fiyat bulunamadı.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int roomPrice = roomPrices[roomType];
                string roomLayout = "Uygun";

                _roomBLL.AddRoom(roomId, roomType, roomPrice, roomLayout);

                MessageBox.Show("Oda başarıyla eklendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadRoomData(); 
                roomTypeCombobox_SelectedIndexChanged(null, null);

                ClearRoomFields(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void roomDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(roomDeleteTxt.Text, out int roomId))
                    throw new ArgumentException("Invalid room ID.");

                _roomBLL.DeleteRoom(roomId);
                MessageBox.Show($"{roomId} numarası başarıyla silindi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearRoomFields();
                LoadRoomData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void roomFullBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(roomLayoutTxt.Text, out int roomId))
                    throw new ArgumentException("Geçersiz oda ID.");

                _roomBLL.UpdateRoomLayout(roomId, "Uygun Değil");
                LoadRoomData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void roomEmptyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(roomLayoutTxt.Text, out int roomId))
                    throw new ArgumentException("Geçersiz oda ID.");

                _roomBLL.UpdateRoomLayout(roomId, "Uygun");
                LoadRoomData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void customerViewBtn_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }
        private void adminRegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdminRegister formAdminRegister = new FormAdminRegister();
            formAdminRegister.Show();
            this.Hide();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            FormAdminEntry formAdminEntry = new FormAdminEntry();
            formAdminEntry.Show();
            this.Hide();
        }
        private void roomListBtn_Click(object sender, EventArgs e)
        {
            FormRoomList formRoomList = new FormRoomList();
            formRoomList.Show();
            this.Hide();
        }
        private void paymentViewBtn_Click(object sender, EventArgs e)
        {
            if (paymentDataGrid.SelectedRows.Count > 0)
            {
                int selectedPaymentId = Convert.ToInt32(paymentDataGrid.SelectedRows[0].Cells["PaymentId"].Value);

                FormPayment formPayment = new FormPayment(selectedPaymentId);
                formPayment.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen bir fatura seçin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void roomChangeBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(roomChangeTxt.Text, out int roomId))
            {
                FormRoomChange formRoomChange = new FormRoomChange(roomId);
                formRoomChange.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçerli bir oda numarası giriniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
