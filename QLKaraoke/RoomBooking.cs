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
    public partial class RoomBooking : Form
    {
        String roomId;
        public RoomBooking()
        {
            InitializeComponent();
        }
        void loadData()
        {
            //Open database

            DatabaseConnect.myConn.Open();
            //Load database
            String sql = "select * from RoomBooking";
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            SqlDataAdapter myDa = new SqlDataAdapter();
            myDa.SelectCommand = myCommand;
            DataTable myDT = new DataTable();
            myDa.Fill(myDT);
            //Load Data into datagridview
            dgvRB.DataSource = myDT;
            //Close 
            DatabaseConnect.myConn.Close();
        }

        private void RoomBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.RoomBooking' table. You can move, or remove it, as needed.
            this.roomBookingTableAdapter.Fill(this.qLResortDataSet.roombooking);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //open connection

            DatabaseConnect.myConn.Open();
            //excecute command

            String sql = "delete from RoomBooking Where orderroom=" + roomId;
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            myCommand.ExecuteNonQuery();


            //close connection
            DatabaseConnect.myConn.Close();
            //load again datagriview
            loadData();
        }

        private void dgvRB_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvRB.CurrentCell.RowIndex;
            roomId = dgvRB.Rows[index].Cells[0].Value.ToString();
        }
    }
}
