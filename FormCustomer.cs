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
    public partial class FormCustomer : Form
    {
        private ReservationManager reservationManager;
        private CustomerManager customerManager;

        public FormCustomer()
        {
            InitializeComponent();
            reservationManager = new ReservationManager();
            customerManager = new CustomerManager();
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            reservationDataGrid.DataSource = reservationManager.GetReservations();

            var customerData = customerManager.GetCustomers();
            if (customerData != null)
            {
                customerDataGrid.DataSource = customerData;
            }
            else
            {
                MessageBox.Show("Müşteri verileri alınamadı.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void reservationDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (reservationDataGrid.SelectedRows.Count > 0)
                {
                    int reservationId = Convert.ToInt32(reservationDataGrid.SelectedRows[0].Cells["ReservationId"].Value);

                    bool isDeleted = reservationManager.DeleteReservationWithInvoice(reservationId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Rezervasyon ve ilişkili fatura başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reservationDataGrid.DataSource = reservationManager.GetReservations();
                    }
                    else
                    {
                        MessageBox.Show("Rezervasyon veya fatura silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz bir rezervasyonu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {
            if (customerDataGrid.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(customerDataGrid.SelectedRows[0].Cells["CustomerId"].Value);
                customerManager.DeleteCustomer(customerId);
                MessageBox.Show("Müşteri silindi.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                customerDataGrid.DataSource = customerManager.GetCustomers();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }
        private void customerRegisterBtn_Click(object sender, EventArgs e)
        {
            FormCustomerRegister formCustomerEntry = new FormCustomerRegister();
            formCustomerEntry.Show();
            this.Hide();
        }
        private void reservationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (customerDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = Convert.ToInt32(customerDataGrid.SelectedRows[0].Cells["CustomerId"].Value);

            FormReservation formReservation = new FormReservation(customerId);
            formReservation.Show();
            this.Hide();
        }

        private void customerChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = Convert.ToInt32(customerDataGrid.SelectedRows[0].Cells["CustomerId"].Value);

                FormCustomerChange formCustomerChange = new FormCustomerChange(customerId);
                formCustomerChange.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Lütfen bir müşteri seçin.","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
