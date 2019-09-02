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
    public partial class FormRoomCheck : Form
    {
        public FormRoomCheck()
        {
            InitializeComponent();
        }

        private void FormRoomCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.qLResortDataSet.Room);
            dtpCheckIn.Visible = false;
            dtpCheckOut.Visible = false;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;

        }

        private void dgvRoom_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvRoom.CurrentCell.RowIndex;
            lbId.Text = dgvRoom.Rows[index].Cells[5].Value.ToString();

            lbRoomId.Text = dgvRoom.Rows[index].Cells[0].Value.ToString();
            lbPeople.Text = dgvRoom.Rows[index].Cells[2].Value.ToString();
            lbMoney.Text = dgvRoom.Rows[index].Cells[3].Value.ToString();
            lbDeposited.Text = dgvRoom.Rows[index].Cells[9].Value.ToString();
            txtStart.Text = dgvRoom.Rows[index].Cells[6].Value.ToString();
            txtEnd.Text = dgvRoom.Rows[index].Cells[7].Value.ToString();

            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.CustomFormat = "HH:mm:ss tt";
            dtpCheckIn.ShowUpDown = true;
            dtpCheckOut.Format = DateTimePickerFormat.Time;
            dtpCheckOut.ShowUpDown = true;
            dtpCheckOut.CustomFormat = "HH:mm:ss tt";


            if (lbId.Text != "")
            {
                //Open database
                DatabaseConnect.myConn.Close();
                DatabaseConnect.myConn.Open();
                //Load database
                String sql = "select * from member where idcard='" + lbId.Text + "'";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                SqlDataAdapter myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                DataTable myDT = new DataTable();
                myDa.Fill(myDT);
                lbPhone.Text = myDT.Rows[0]["phone"].ToString();
                lbName.Text = myDT.Rows[0]["name"].ToString();

                //Close
                DatabaseConnect.myConn.Close();

            }
            else
            {
                lbName.Text = "";
                lbPhone.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Remove Order", "Are you sure ?",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                //Open database

                DatabaseConnect.myConn.Open();
                //Load database

                String sql = "update Room set idcard=" + "NULL" + ",timestart=" + "NULL" + ",timeend=" + "NULL" + ",paid=0,coupon=0 where idroom='" + lbRoomId.Text + "'";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();


                sql = "delete from RoomBooking where idroom='" + lbRoomId.Text + "' and checkin='" + txtStart.Text + "' and checkout='" + txtEnd.Text + "'";
                myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();


                loadData();
                //Close
                DatabaseConnect.myConn.Close();
            }

        }
        void loadData()
        {
            //Open database
            DatabaseConnect.myConn.Close();
            DatabaseConnect.myConn.Open();
            //Load database
            String sql = "select * from Room";
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            SqlDataAdapter myDa = new SqlDataAdapter();
            myDa.SelectCommand = myCommand;
            DataTable myDT = new DataTable();
            myDa.Fill(myDT);
            //Load Data into datagridview
            dgvRoom.DataSource = myDT;
            //Close 
            DatabaseConnect.myConn.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
            dtpCheckOut.Visible = true;
            dtpCheckIn.Visible = true;
            btnRemove.Visible = false;
            btnChange.Visible = false;
            if (txtStart.Text != "")
            {
                DateTime dt = DateTime.Parse(txtStart.Text);
                dtpCheckIn.Value = dt;
            }
            if (txtEnd.Text != "" && txtEnd.Text != "Unknow")
            {
                DateTime dt = DateTime.Parse(txtEnd.Text);
                dtpCheckOut.Value = dt;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnConfirm.Visible = false;
            dtpCheckIn.Visible = false;
            dtpCheckOut.Visible = false;
            btnChange.Visible = true;
            btnRemove.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //open connection
            String ConnStr = "Server=DESKTOP-UNV9GNN\\SQLEXPRESS;Initial Catalog=QLKaraoke_DB;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(ConnStr);
            myConn.Open();
            //excecute command

            String sql = "update Room set  timestart='" + dtpCheckIn.Text + "',timeend='" + dtpCheckOut.Text + "'where idroom ='" + lbRoomId.Text + "'";
            SqlCommand myCommand = new SqlCommand(sql, myConn);
            myCommand.ExecuteNonQuery();



            sql = "update roombooking set checkin='" + dtpCheckIn.Text + "', checkout='" + dtpCheckOut.Text + "' where idroom='" + lbRoomId.Text + "' and checkin='" + txtStart.Text + "' and checkout='" + txtEnd.Text + "'";
            myCommand = new SqlCommand(sql, myConn);
            myCommand.ExecuteNonQuery();

            //close connection
            myConn.Close();
            //load again datagriview
            loadData();





            btnCancel.Visible = false;
            btnConfirm.Visible = false;
            dtpCheckIn.Visible = false;
            dtpCheckOut.Visible = false;
            btnChange.Visible = true;
            btnRemove.Visible = true;

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RoomBooking newform = new RoomBooking();
            newform.Show();
        }
    }
}
