using OtelOtomasyonu.DataAccessLayer;
using OtelOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelOtomasyonu.LogicLayer
{
    public class RoomManager
    {
        private readonly RoomDal _roomDAL = new RoomDal();

        public List<Tuple<int, string>> GetRooms() => _roomDAL.GetRooms();

        public List<string> GetRoomTypes() => _roomDAL.GetRoomTypes();

        public Dictionary<string, int> GetRoomPrices() => _roomDAL.GetRoomPrices();
        public void AddRoom(int roomId, string roomType, int roomPrice, string roomLayout)
        {
            _roomDAL.AddRoom(roomId, roomType, roomPrice, roomLayout);
        }
        public int GetRoomPriceByNumber(string roomNumber)
        {
            return _roomDAL.GetRoomPriceByNumber(roomNumber);
        }
        public List<string> GetRoomNumbersByType(string roomType)
        {
            return _roomDAL.GetRoomNumbersByType(roomType);
        }
        public void DeleteRoom(int roomId)
        {
            if (roomId <= 0)
                throw new ArgumentException("Oda ID sıfırdan büyük olmalı.");
            _roomDAL.DeleteRoom(roomId);
        }
        public void UpdateRoomLayout(int roomId, string layout)
        {
            if (roomId <= 0)
                throw new ArgumentException("Oda ID sıfırdan büyük olmalı.");
            if (string.IsNullOrWhiteSpace(layout))
                throw new ArgumentException("Oda düzeni boş olamaz.");
            _roomDAL.UpdateRoomLayout(roomId, layout);
            MessageBox.Show($"Numarası {roomId} olan oda '{layout}' olarak değiştirildi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public List<Room> GetAllRooms()
        {
            return _roomDAL.GetAllRooms();
        }
        public DataRow GetRoomDetails(int roomId)
        {
            return _roomDAL.GetRoomDetails(roomId);
        }
        public void UpdateRoomDetails(int roomId, string roomType, int roomPrice)
        {
            _roomDAL.UpdateRoomDetails(roomId, roomType, roomPrice);
        }
        public int GetRoomPriceByRoomType(string roomType)
        {
            return _roomDAL.GetRoomPriceByRoomType(roomType);
        }
    }
}
