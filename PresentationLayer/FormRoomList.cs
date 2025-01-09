using OtelOtomasyonu.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class FormRoomList : Form
    {
        private RoomManager roomManager;
        public FormRoomList()
        {
            InitializeComponent();
            roomManager = new RoomManager();
        }
        private void FormRoomList_Load(object sender, EventArgs e)
        {
            LoadRoomList();
        }
        private void LoadRoomList()
        {
            try
            {
                var rooms = roomManager.GetAllRooms();
                roomListData.DataSource = rooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oda listesi yüklenirken bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }
    }
}
