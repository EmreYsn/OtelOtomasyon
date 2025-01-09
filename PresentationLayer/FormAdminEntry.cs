using MySql.Data.MySqlClient;
using OtelOtomasyonu.DataAccessLayer;
using OtelOtomasyonu.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelOtomasyonu
{
    public partial class FormAdminEntry : Form
    {
        private AdminManager _adminManager;
        public FormAdminEntry()
        {
            InitializeComponent();
            _adminManager = new AdminManager(new AdminDal(new Connection().connectionGet()));
        }
        private void entryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nickname = adminEntryTxt.Text;
                string password = adminPasswordTxt.Text; 

                if (string.IsNullOrEmpty(password)) 
                {
                    MessageBox.Show("Şifreyi giriniz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_adminManager.AuthenticateAdmin(nickname, password))
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
