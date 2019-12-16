using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKaraoke
{
    public partial class FormRoomBooking : Form
    {
        int roomId;
        public FormRoomBooking()
        {
            InitializeComponent();
        }
        void loadData()
        {

            var lstRoomBooking = DatabaseConnect.db.roombookings.ToList();
            dgvRB.DataSource = lstRoomBooking;
        }

        private void RoomBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.RoomBooking' table. You can move, or remove it, as needed.
            this.roomBookingTableAdapter.Fill(this.qLResortDataSet.roombooking);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var room = DatabaseConnect.db.roombookings.Where(s => s.orderroom == roomId).SingleOrDefault();
            DatabaseConnect.db.roombookings.Remove(room);
            DatabaseConnect.db.SaveChanges();
            //load again datagriview
            loadData();
        }

        private void dgvRB_SelectionChanged(object sender, EventArgs e)
        {
            var curRow = dgvRB.CurrentRow;
            if (curRow != null)
            {
                int index = dgvRB.CurrentCell.RowIndex;
                roomId = Int16.Parse(dgvRB.Rows[index].Cells[0].Value.ToString());
            }
               
            

        }
    }
}
