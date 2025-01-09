using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.EntityLayer
{
    public class Reservation
    {
        public int reservationId;
        public int roomId;
        public DateTime entryTime;
        public DateTime exitTime;
        public int customerId;

        public int ReservationId { get => reservationId; set => reservationId = value; }
        public int RoomId { get => roomId; set => roomId = value; }
        public DateTime EntryTime { get => entryTime; set => entryTime = value; }
        public DateTime ExitTime { get => exitTime; set => exitTime = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
    }
}
