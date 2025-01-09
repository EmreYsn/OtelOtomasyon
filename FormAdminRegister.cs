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
    public partial class FormAdminRegister : Form
    {
        private AdminManager _adminManager;
        public FormAdminRegister()
        {
            InitializeComponent();
            _adminManager = new AdminManager(new AdminDal(new Connection().connectionGet()));
        }
        private void adminRegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordAgainTxt.Text != adminPasswordTxt.Text)
                {
                    MessageBox.Show("Lütfen bilgileri doğru giriniz.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (adminNameTxt.Text == "" || adminSurnameTxt.Text == "" || adminPasswordTxt.Text == "" || adminNicknameTxt.Text == "" || passwordAgainTxt.Text == "")
                {
                    MessageBox.Show("Lütfen bütün bilgileri giriniz.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (adminPasswordTxt.Text == passwordAgainTxt.Text && adminNameTxt.Text != "" && adminSurnameTxt.Text != "" && adminPasswordTxt.Text != "" && adminNicknameTxt.Text != "")
                {
                    Admin admin = new Admin
                    {
                        AdminName = adminNameTxt.Text,
                        AdminSurname = adminSurnameTxt.Text,
                        AdminNickname = adminNicknameTxt.Text,
                        AdminPassword = adminPasswordTxt.Text
                    };

                    _adminManager.RegisterAdmin(admin);

                    MessageBox.Show($"Kaydınız başarıyla gerçekleştirilmiştir. {"\n"} Şifreniz: {admin.AdminPassword}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
