using OtelOtomasyonu.DataAccessLayer;
using OtelOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.LogicLayer
{
    public class CustomerManager
    {
        private CustomerDal _customerDal;

        public CustomerManager()
        {
            _customerDal = new CustomerDal();
        }
        public DataTable GetCustomers()
        {
            return _customerDal.GetCustomers();
        }
        public void DeleteCustomer(int customerId)
        {
            _customerDal.DeleteCustomer(customerId);
        }
        public DataRow GetCustomerById(int customerId)
        {
            return _customerDal.GetCustomerById(customerId);
        }
        public void RegisterCustomer(Customer customer)
        {
            _customerDal.AddCustomer(customer);
        }
        public DataRow GetCustomerDetails(int customerId)
        {
            return _customerDal.GetCustomerDetails(customerId);
        }
        public void UpdateCustomerDetails(int customerId,string customerName,string customerSurname,long customerPhoneNumber)
        {
            _customerDal.UpdateCustomerDetails(customerId,customerName,customerSurname,customerPhoneNumber);
        }
    }
}
