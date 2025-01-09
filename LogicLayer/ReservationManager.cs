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
    public class ReservationManager
    {
        private ReservationDal reservationDal;
        private PaymentManager paymentManager;

        public ReservationManager()
        {
            reservationDal = new ReservationDal();
            paymentManager = new PaymentManager();
        }
        public DataTable GetReservations()
        {
            return reservationDal.GetReservations();
        }
        public bool IsRoomAvailable(int roomId, DateTime entryTime, DateTime exitTime)
        {
            return reservationDal.IsRoomAvailable(roomId, entryTime, exitTime);
        }
        public List<int> GetAvailableRooms(DateTime entryTime, DateTime exitTime)
        {
            return reservationDal.GetAvailableRooms(entryTime, exitTime);
        }
        public int AddReservation(Reservation reservation)
        {
            return reservationDal.AddReservation(reservation);
        }
        public bool DeleteReservationWithInvoice(int reservationId)
        {
            try
            {
                bool isInvoiceDeleted = paymentManager.DeleteInvoiceByReservationId(reservationId);
                bool isReservationDeleted = reservationDal.DeleteReservation(reservationId);

                return isInvoiceDeleted && isReservationDeleted;
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyon ve fatura silme işlemi sırasında bir hata oluştu.", ex);
            }
        }

    }
}
