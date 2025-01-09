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
    public partial class FormPayment : Form
    {
        private readonly PaymentManager _paymentManager;
        private int _selectedPaymentId;
        public FormPayment(int paymentId)
        {
            InitializeComponent();
            _paymentManager = new PaymentManager();
            _selectedPaymentId = paymentId;
        }
        private void FormPayment_Load(object sender, EventArgs e)
        {
            LoadPaymentDetails();
        }
        private void LoadPaymentDetails()
        {
            DataRow paymentDetails = _paymentManager.GetPaymentDetails(_selectedPaymentId);

            if (paymentDetails != null)
            {
                nameTxt.Text = paymentDetails["CustomerName"].ToString();
                surnameTxt.Text = paymentDetails["CustomerSurname"].ToString();
                phoneNumberTxt.Text = paymentDetails["CustomerPhoneNumber"].ToString();

                roomNumberTxt.Text = paymentDetails["RoomId"].ToString();
                roomTypeTxt.Text = paymentDetails["RoomType"].ToString();
                roomPriceTxt.Text = paymentDetails["RoomPrice"].ToString();

                reservationIdTxt.Text = paymentDetails["ReservationId"].ToString();
                entryTimeTxt.Text = Convert.ToDateTime(paymentDetails["EntryTime"]).ToString("dd-MM-yyyy");
                exitTimeTxt.Text = Convert.ToDateTime(paymentDetails["ExitTime"]).ToString("dd-MM-yyyy");
                totalPriceTxt.Text = paymentDetails["TotalPrice"].ToString();
            }
            else
            {
                MessageBox.Show("Fatura bilgileri yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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
