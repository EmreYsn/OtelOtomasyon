using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.EntityLayer
{
    public class Customer
    {
        public int customerId;
        public string customerName;
        public string customerSurname;
        public long customerPhoneNumber;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerSurname { get => customerSurname; set => customerSurname = value; }
        public long CustomerPhoneNumber { get => customerPhoneNumber; set => customerPhoneNumber = value; }
    }
}
