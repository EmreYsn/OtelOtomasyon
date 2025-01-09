using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.EntityLayer
{
    public class Admin
    {
        public int adminId;
        public string adminName;
        public string adminSurname;
        public string adminNickname;
        public string adminPassword;

        public int AdminId { get => adminId; set => adminId = value; }
        public string AdminName { get => adminName; set => adminName = value; }
        public string AdminSurname { get => adminSurname; set => adminSurname = value; }
        public string AdminNickname { get => adminNickname; set => adminNickname = value; }
        public string AdminPassword { get => adminPassword; set => adminPassword = value; }
    }
}
