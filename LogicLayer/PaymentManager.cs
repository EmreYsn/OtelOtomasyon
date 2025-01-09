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
    public class PaymentManager
    {
        private readonly PaymentDal _paymentDal;

        public PaymentManager()
        {
            _paymentDal = new PaymentDal();
        }

        public void AddPayment(Payment payment)
        {
            _paymentDal.AddPayment(payment);
        }
        public DataTable GetAllPayments()
        {
            return _paymentDal.GetAllPayments();
        }
        public DataRow GetPaymentDetails(int paymentId)
        {
            return _paymentDal.GetPaymentDetails(paymentId);
        }
        public bool DeleteInvoiceByReservationId(int reservationId)
        {
            return _paymentDal.DeleteInvoiceByReservationId(reservationId);
        }
    }
}
