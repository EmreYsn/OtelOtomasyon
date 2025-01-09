using OtelOtomasyonu.EntityLayer;
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
    public partial class FormReservation : Form
    {
        private CustomerManager _customerManager;
        private RoomManager _roomManager;
        private ReservationManager _reservationManager;
        private int _customerId;

        public FormReservation(int customerId)
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
            _roomManager = new RoomManager();
            _reservationManager = new ReservationManager();
            _customerId = customerId;
        }
        private void FormReservation_Load(object sender, EventArgs e)
        {
            LoadCustomerInfo();

            List<string> roomTypes = _roomManager.GetRoomTypes();
            roomTypeCombobox.DataSource = roomTypes;
            roomTypeCombobox.SelectedIndex = -1;

            roomTypeCombobox.SelectedIndexChanged += roomTypeCombobox_SelectedIndexChanged;
            roomNumberCombobox.SelectedIndexChanged += roomNumberCombobox_SelectedIndexChanged;
        }
        private void LoadCustomerInfo()
        {
            DataRow customer = _customerManager.GetCustomerById(_customerId);

            if (customer != null)
            {
                phoneNumberTxt.Text = customer["CustomerPhoneNumber"].ToString();
                customerNameTxt.Text = customer["CustomerName"].ToString();
                customerSurnameTxt.Text = customer["CustomerSurname"].ToString();
            }
            else
            {
                MessageBox.Show("Müşteri bilgileri yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void LoadAvailableRooms()
        {
            try
            {
                DateTime entryTime = entryTimePicker.Value;
                DateTime exitTime = exitTimePicker.Value;

                var availableRooms = _reservationManager.GetAvailableRooms(entryTime, exitTime);

                roomNumberCombobox.Items.Clear();

                if (availableRooms.Count > 0)
                {
                    foreach (var roomId in availableRooms)
                    {
                        roomNumberCombobox.Items.Add(roomId);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen tarihlerde uygun oda bulunmamaktadır.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oda yükleme sırasında bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }
        private void entryTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker entryTimePicker = sender as DateTimePicker;

            if (entryTimePicker != null)
            {
                DateTime selectedDate = entryTimePicker.Value;

                if (selectedDate < DateTime.Today)
                {
                    MessageBox.Show("Lütfen bugünden sonraki bir tarih seçin!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    entryTimePicker.Value = DateTime.Today;
                }
                else
                {
                    LoadAvailableRooms();
                }
            }
        }
        private void exitTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker exitTimePicker = sender as DateTimePicker;

            if (exitTimePicker != null)
            {
                DateTime selectedDate2 = exitTimePicker.Value;

                DateTime selectedDate1 = entryTimePicker.Value;

                if (selectedDate2 < selectedDate1)
                {
                    MessageBox.Show("Çıkış tarihi, giriş tarihinden sonraki bir tarih olmalıdır!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    exitTimePicker.Value = selectedDate1.AddDays(1);
                }
                else
                {
                    LoadAvailableRooms();
                }
            }

        }
        private void roomTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomTypeCombobox.SelectedIndex == -1)
            {
                roomNumberCombobox.DataSource = null;
                return;
            }

            string selectedRoomType = roomTypeCombobox.Text;
            List<string> roomNumbers = _roomManager.GetRoomNumbersByType(selectedRoomType);

            roomNumberCombobox.DataSource = roomNumbers;
            roomNumberCombobox.SelectedIndex = -1;
        }
        private void roomNumberCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomNumberCombobox.SelectedIndex == -1)
            {
                roomPriceTxt.Text = string.Empty;
                return;
            }

            string selectedRoomNumber = roomNumberCombobox.Text;
            int roomPrice = _roomManager.GetRoomPriceByNumber(selectedRoomNumber);

            roomPriceTxt.Text = roomPrice.ToString();
        }
        private void reservationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (roomNumberCombobox.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir oda numarası seçin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedRoomId = Convert.ToInt32(roomNumberCombobox.SelectedItem);
                DateTime entryTime = entryTimePicker.Value;
                DateTime exitTime = exitTimePicker.Value;

                if (_reservationManager.IsRoomAvailable(selectedRoomId, entryTime, exitTime))
                {
                    var reservation = new Reservation
                    {
                        RoomId = selectedRoomId,
                        CustomerId = _customerId,
                        EntryTime = entryTime,
                        ExitTime = exitTime
                    };

                    int reservationId = _reservationManager.AddReservation(reservation);

                    var roomPrice = Convert.ToDecimal(roomPriceTxt.Text);
                    var totalDays = (exitTime - entryTime).Days;
                    var totalPrice = roomPrice * totalDays;

                    if (totalDays == 0)
                    {
                        totalPrice = roomPrice;
                    }

                    var payment = new Payment
                    {
                        ReservationId = reservationId,
                        CustomerId = _customerId,
                        TotalPrice = totalPrice
                    };

                    var paymentManager = new PaymentManager();
                    paymentManager.AddPayment(payment);

                    MessageBox.Show("Rezervasyon ve fatura başarıyla eklendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Oda uygun değil. Lütfen farklı bir tarih veya oda seçin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
