using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelOtomasyonu.EntityLayer;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;

namespace OtelOtomasyonu.DataAccessLayer
{
    public class CustomerDal
    {
        private Connection connectionHelper;
        public CustomerDal()
        {
            connectionHelper = new Connection();
        }
        public DataTable GetCustomers()
        {
            using (MySqlConnection conn = connectionHelper.connectionGet())
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM TblCustomer", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void DeleteCustomer(int customerId)
        {
            using (MySqlConnection conn = connectionHelper.connectionGet())
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM TblCustomer WHERE CustomerId = @CustomerId", conn);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.ExecuteNonQuery();
            }
        }
        public DataRow GetCustomerById(int customerId)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT * FROM TblCustomer WHERE CustomerId = @CustomerId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            return table.Rows[0];
                        }
                        return null;
                    }
                }
            }
        }
        public void AddCustomer(Customer customer)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO TblCustomer (CustomerName, CustomerSurname, CustomerPhoneNumber) VALUES (@p1, @p2, @p3)", (new Connection().connectionGet()));
                command.Parameters.AddWithValue("@p1", customer.CustomerName);
                command.Parameters.AddWithValue("@p2", customer.CustomerSurname);
                command.Parameters.AddWithValue("@p3", customer.CustomerPhoneNumber);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Customer could not be added to the database.", ex);
            }
        }
        public DataRow GetCustomerDetails(int customerId)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "SELECT CustomerName , CustomerSurname , CustomerPhoneNumber FROM TblCustomer WHERE CustomerId = @CustomerId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0) { return dataTable.Rows[0]; } else { return null; }
                    }
                }
            }
        }
        public void UpdateCustomerDetails(int customerId,string customerName, string customerSurname ,long customerPhoneNumber)
        {
            using (MySqlConnection connection = (new Connection()).connectionGet())
            {
                string query = "UPDATE TblCustomer SET CustomerName = @CustomerName, CustomerSurname = @CustomerSurname, CustomerPhoneNumber = @CustomerPhoneNumber WHERE CustomerId = @CustomerId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@CustomerSurname", customerSurname);
                    command.Parameters.AddWithValue("@CustomerPhoneNumber", customerPhoneNumber);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}