using MySql.Data.MySqlClient;
using OtelOtomasyonu.EntityLayer;
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
    public class PaymentDal
    {
        public void AddPayment(Payment payment)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                using (var command = new MySqlCommand(
                    "INSERT INTO TblPayment (ReservationId, CustomerId, TotalPrice) VALUES (@ReservationId, @CustomerId, @TotalPrice)",
                    connection))
                {
                    command.Parameters.AddWithValue("@ReservationId", payment.ReservationId);
                    command.Parameters.AddWithValue("@CustomerId", payment.CustomerId);
                    command.Parameters.AddWithValue("@TotalPrice", payment.TotalPrice);

                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetAllPayments()
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                using (var command = new MySqlCommand("SELECT * FROM TblPayment", connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable paymentData = new DataTable();
                        adapter.Fill(paymentData);
                        return paymentData;
                    }
                }
            }
        }
        public DataRow GetPaymentDetails(int paymentId)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = @"
                SELECT 
                    c.CustomerName, 
                    c.CustomerSurname, 
                    c.CustomerPhoneNumber, 
                    r.RoomId, 
                    r.RoomType, 
                    r.RoomPrice, 
                    res.ReservationId, 
                    res.EntryTime, 
                    res.ExitTime, 
                    p.TotalPrice
                FROM TblPayment p
                INNER JOIN TblReservation res ON p.ReservationId = res.ReservationId
                INNER JOIN TblCustomer c ON p.CustomerId = c.CustomerId
                INNER JOIN TblRoom r ON res.RoomId = r.RoomId
                WHERE p.PaymentId = @PaymentId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentId", paymentId);

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
        public bool DeleteInvoiceByReservationId(int reservationId)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "DELETE FROM TblPayment WHERE ReservationId = @ReservationId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationId", reservationId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}

