using OtelOtomasyonu.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class FormRoomChange : Form
    {
        private readonly RoomManager _roomManager;
        private int _roomId;
        public FormRoomChange(int roomId)
        {
            InitializeComponent();
            _roomManager = new RoomManager();
            _roomId = roomId;
        }
        private void FormRoomChange_Load(object sender, EventArgs e)
        {
            LoadRoomDetails();
            LoadRoomTypes();
        }
        private void LoadRoomDetails()
        {
            var roomDetails = _roomManager.GetRoomDetails(_roomId);

            if (roomDetails != null)
            {
                roomIdTxt.Text = roomDetails["RoomId"].ToString();
                roomTypeCombobox.SelectedItem = roomDetails["RoomType"].ToString(); 
                roomPriceTxt.Text = roomDetails["RoomPrice"].ToString();
            }
            else
            {
                MessageBox.Show("Oda bilgileri yüklenemedi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void LoadRoomTypes()
        {
            List<string> roomTypes = _roomManager.GetRoomTypes();

            if (roomTypes != null && roomTypes.Count > 0)
            {
                roomTypeCombobox.DataSource = roomTypes;
            }
            else
            {
                MessageBox.Show("Oda tipleri yüklenemedi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void roomTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomTypeCombobox.SelectedItem != null)
            {
                string selectedRoomType = roomTypeCombobox.SelectedItem.ToString();
                int newRoomPrice = _roomManager.GetRoomPriceByRoomType(selectedRoomType);

                roomPriceTxt.Text = newRoomPrice.ToString();
            }
        }
        private void roomChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (roomTypeCombobox.SelectedItem != null && int.TryParse(roomPriceTxt.Text, out int roomPrice))
                {
                    string roomTypeChar = roomTypeCombobox.SelectedItem?.ToString();

                    _roomManager.UpdateRoomDetails(_roomId, roomTypeChar, roomPrice);

                    MessageBox.Show("Oda bilgileri başarıyla güncellendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir oda tipi ve fiyatı giriniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }
    }
}