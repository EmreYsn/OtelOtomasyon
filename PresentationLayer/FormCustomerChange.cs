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
    public partial class FormCustomerChange : Form
    {
        private readonly CustomerManager _customerManager;
        private int _customerId;
        public FormCustomerChange(int customerId)
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
            _customerId = customerId;
        }
        private void FormCustomerChange_Load(object sender, EventArgs e)
        {
            LoadCustomerDetails();
        }
        private void LoadCustomerDetails()
        {
            var customerDetails = _customerManager.GetCustomerDetails(_customerId);

            if (customerDetails != null)
            {
                nameTxt.Text = customerDetails["CustomerName"].ToString();
                surnameTxt.Text = customerDetails["CustomerSurname"].ToString();
                phoneNumberTxt.Text = customerDetails["CustomerPhoneNumber"].ToString();
            }
            else
            {
                 MessageBox.Show("Müşteri bilgisi yüklenemedi","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void customerChangeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (nameTxt.Text)  || string.IsNullOrEmpty (surnameTxt.Text) || string.IsNullOrEmpty( phoneNumberTxt.Text))
            {
                MessageBox.Show("Lütfen geçerli bilgileri tam giriniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cleanedPhoneNumber = phoneNumberTxt.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                string newName = nameTxt.Text;
                string newSurname = surnameTxt.Text;
                long newPhoneNumber = Convert.ToInt64(cleanedPhoneNumber);

                _customerManager.UpdateCustomerDetails(_customerId, newName, newSurname, newPhoneNumber);
                MessageBox.Show("Müşteri bilgisi başarıyla güncellendi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }
    }
}