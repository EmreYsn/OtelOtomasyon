using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelOtomasyonu.DataAccessLayer;
using OtelOtomasyonu.EntityLayer;
namespace OtelOtomasyonu.LogicLayer
{
    public class AdminManager
    {
        private AdminDal _adminDal;
        public AdminManager(AdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public bool AuthenticateAdmin(string nickname, string password)
        {
            Admin admin = _adminDal.GetAdminByNicknameAndPassword(nickname, password);
            return admin != null;
        }
        public void RegisterAdmin(Admin admin)
        {
            _adminDal.AddAdmin(admin);
        }
    }
}
