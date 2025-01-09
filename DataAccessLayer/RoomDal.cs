using MySql.Data.MySqlClient;
using OtelOtomasyonu.EntityLayer;
using OtelOtomasyonu.LogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.DataAccessLayer
{
    public class RoomDal
    {
        public List<Tuple<int, string>> GetRooms()
        {
            var rooms = new List<Tuple<int, string>>();
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT RoomId, RoomType FROM TblRoom";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int roomId = reader.GetInt32("RoomId");
                        string roomType = reader.GetString("RoomType");
                        rooms.Add(Tuple.Create(roomId, roomType));
                    }
                }
            }
            return rooms;
        }
        public List<string> GetRoomTypes()
        {
            var roomTypes = new List<string>();
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT DISTINCT RoomType FROM TblRoom";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roomTypes.Add(reader.GetString("RoomType"));
                    }
                }
            }
            return roomTypes;
        }
        public List<string> GetRoomNumbersByType(string roomType)
        {
            var roomNumbers = new List<string>();
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT RoomId FROM TblRoom WHERE RoomType = @RoomType";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomType", roomType);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roomNumbers.Add(reader.GetInt32("RoomId").ToString());
                        }
                    }
                }
            }
            return roomNumbers;
        }
        public Dictionary<string, int> GetRoomPrices()
        {
            var roomPrices = new Dictionary<string, int>();
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT RoomType, RoomPrice FROM TblRoom";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string roomType = reader.GetString("RoomType");
                        int roomPrice = reader.GetInt32("RoomPrice");
                        roomPrices[roomType] = roomPrice;
                    }
                }
            }
            return roomPrices;
        }
        public int GetRoomPriceByNumber(string roomNumber)
        {
            int roomPrice = 0;
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT RoomPrice FROM TblRoom WHERE RoomId = @RoomId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomNumber);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            roomPrice = reader.GetInt32("RoomPrice");
                        }
                    }
                }
            }
            return roomPrice;
        }
        public void AddRoom(int roomId, string roomType, int roomPrice, string roomLayout)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "INSERT INTO TblRoom (RoomId, RoomType, RoomPrice, RoomLayout) VALUES (@RoomId, @RoomType, @RoomPrice, @RoomLayout)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.Parameters.AddWithValue("@RoomType", roomType); 
                    command.Parameters.AddWithValue("@RoomPrice", roomPrice);
                    command.Parameters.AddWithValue("@RoomLayout", roomLayout);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteRoom(int roomId)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "DELETE FROM TblRoom WHERE RoomId = @RoomId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateRoomLayout(int roomId, string layout)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "UPDATE TblRoom SET RoomLayout = @RoomLayout WHERE RoomId = @RoomId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.Parameters.AddWithValue("@RoomLayout", layout);
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT RoomId, RoomType, RoomPrice, RoomLayout FROM TblRoom";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new Room
                        {
                            RoomId = reader.GetInt32("RoomId"),
                            RoomType = reader.GetChar("RoomType"), 
                            RoomPrice = reader.GetInt32("RoomPrice"),
                            RoomLayout = reader.GetString("RoomLayout")
                        });
                    }
                }
            }
            return rooms;
        }
        public DataRow GetRoomDetails(int roomId)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT RoomId, RoomType, RoomPrice FROM TblRoom WHERE RoomId = @RoomId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            return table.Rows[0];
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public int GetRoomPriceByRoomType(string roomType)
        {
            int roomPrice = 0;
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT RoomPrice FROM TblRoom WHERE RoomType = @RoomType LIMIT 1";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomType", roomType);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            roomPrice = reader.GetInt32("RoomPrice");
                        }
                    }
                }
            }
            return roomPrice;
        }

        public void UpdateRoomDetails(int roomId, string roomType, int roomPrice)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "UPDATE TblRoom SET RoomType = @RoomType, RoomPrice = @RoomPrice WHERE RoomId = @RoomId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.Parameters.AddWithValue("@RoomType", roomType);
                    command.Parameters.AddWithValue("@RoomPrice", roomPrice);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
