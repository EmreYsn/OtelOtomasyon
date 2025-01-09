using MySql.Data.MySqlClient;
using OtelOtomasyonu.DataAccessLayer;
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
    public partial class FormCustomerRegister : Form
    {
        private CustomerManager _customerManager;
        public FormCustomerRegister()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTxt.Text == "" || surnameTxt.Text == "" || customerPhoneNumberTxt.Text == "")
                {
                    MessageBox.Show("Lütfen bilgileri giriniz.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (nameTxt.Text != "" && surnameTxt.Text != "" && customerPhoneNumberTxt.Text != "")
                {
                    string cleanedPhoneNumber = customerPhoneNumberTxt.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                    Customer customer = new Customer
                    {
                        CustomerName = nameTxt.Text,
                        CustomerSurname = surnameTxt.Text,
                        CustomerPhoneNumber = Int64.Parse(cleanedPhoneNumber)
                    };

                    _customerManager.RegisterCustomer(customer);

                    MessageBox.Show($"Kaydınız başarıyla gerçekleştirilmiştir.{"\n"} Telefon Numarası: {customer.CustomerPhoneNumber}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
