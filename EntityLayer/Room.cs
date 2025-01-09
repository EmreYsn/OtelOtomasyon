using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.EntityLayer
{
    public class Room
    {
        public int roomId;
        public char roomType;
        public int roomPrice;
        public string roomLayout;

        public int RoomId { get => roomId; set => roomId = value; }
        public char RoomType { get => roomType; set => roomType = value; }
        public int RoomPrice { get => roomPrice; set => roomPrice = value; }
        public string RoomLayout { get => roomLayout; set => roomLayout = value; }
    }
}
