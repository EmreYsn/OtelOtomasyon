using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelOtomasyonu.EntityLayer;

namespace OtelOtomasyonu.DataAccessLayer
{
    public class ReservationDal
    {
        private Connection connectionHelper;

        public ReservationDal()
        {
            connectionHelper = new Connection();
        }
        public DataTable GetReservations()
        {
            using (MySqlConnection conn = connectionHelper.connectionGet())
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM TblReservation", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool DeleteReservation(int reservationId)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "DELETE FROM TblReservation WHERE ReservationId = @ReservationId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationId", reservationId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool IsRoomAvailable(int roomId, DateTime entryTime, DateTime exitTime)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = @"
            SELECT COUNT(*) 
            FROM TblReservation 
            WHERE RoomId = @RoomId 
              AND (EntryTime < @ExitTime AND ExitTime > @EntryTime)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.Parameters.AddWithValue("@EntryTime", entryTime);
                    command.Parameters.AddWithValue("@ExitTime", exitTime);

                    var result = Convert.ToInt32(command.ExecuteScalar());
                    return result == 0;
                }
            }
        }
        public List<int> GetAvailableRooms(DateTime entryTime, DateTime exitTime)
        {
            var availableRooms = new List<int>();

            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = @"
            SELECT RoomId 
            FROM TblRoom 
            WHERE RoomId NOT IN (
                SELECT RoomId 
                FROM TblReservation 
                WHERE (EntryTime < @ExitTime AND ExitTime > @EntryTime)
            )";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EntryTime", entryTime);
                    command.Parameters.AddWithValue("@ExitTime", exitTime);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            availableRooms.Add(reader.GetInt32("RoomId"));
                        }
                    }
                }
            }
            return availableRooms;
        }
        public int AddReservation(Reservation reservation)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                using (var command = new MySqlCommand(
                    "INSERT INTO TblReservation (RoomId, CustomerId, EntryTime, ExitTime) VALUES (@RoomId, @CustomerId, @EntryTime, @ExitTime); SELECT LAST_INSERT_ID();",
                    connection))
                {
                    command.Parameters.AddWithValue("@RoomId", reservation.RoomId);
                    command.Parameters.AddWithValue("@CustomerId", reservation.CustomerId);
                    command.Parameters.AddWithValue("@EntryTime", reservation.EntryTime);
                    command.Parameters.AddWithValue("@ExitTime", reservation.ExitTime);

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int reservationId))
                    {
                        return reservationId;
                    }
                    else
                    {
                        throw new Exception("Rezervasyon ID alınamadı.");
                    }
                }
            }
        }
    }
}
