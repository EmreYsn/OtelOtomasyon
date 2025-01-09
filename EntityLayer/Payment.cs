using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.EntityLayer
{
    public class Payment
    {
        public int paymentId;
        public int reservationId;
        public int customerId;
        public decimal totalPrice;

        public int PaymentId { get => paymentId; set => paymentId = value; }
        public int ReservationId { get => reservationId; set => reservationId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public decimal TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
