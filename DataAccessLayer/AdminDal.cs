using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelOtomasyonu.EntityLayer;

namespace OtelOtomasyonu.DataAccessLayer
{
    public class AdminDal
    {
        private MySqlConnection _connection;

        public AdminDal(MySqlConnection connection)
        {
            _connection = connection;
        }
        public Admin GetAdminByNicknameAndPassword(string nickname, string password)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM TblAdmin WHERE AdminNickname = @p1 AND AdminPassword = @p2", _connection);
                command.Parameters.AddWithValue("@p1", nickname);
                command.Parameters.AddWithValue("@p2", password); 

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Admin
                        {
                            AdminId = reader.GetInt32("AdminId"),
                            AdminName = reader.GetString("AdminName"),
                            AdminSurname = reader.GetString("AdminSurname"),
                            AdminNickname = reader.GetString("AdminNickname"),
                            AdminPassword = reader.GetString("AdminPassword")
                        };
                    }
                    else
                    {
                        return null; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error occurred while fetching admin.", ex);
            }
        }
        public void AddAdmin(Admin admin)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO TblAdmin (AdminName, AdminSurname, AdminNickname, AdminPassword) VALUES (@p1, @p2, @p3, @p4)", _connection);
                command.Parameters.AddWithValue("@p1", admin.AdminName);
                command.Parameters.AddWithValue("@p2", admin.AdminSurname);
                command.Parameters.AddWithValue("@p3", admin.AdminNickname);
                command.Parameters.AddWithValue("@p4", admin.AdminPassword);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Admin could not be added to the database.", ex);
            }
        }
    }
}
