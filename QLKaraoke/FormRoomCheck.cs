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
            var curRow = dgvRoom.CurrentRow;
<<<<<<< HEAD
            if (curRow != null && dgvRoom.Rows[0].Cells[5].Value != null)
=======
            if (curRow != null && dgvRoom.Rows[0].Cells[5].Value!=null)
>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a
            {
                int index = dgvRoom.CurrentCell.RowIndex;

                lbId.Text = dgvRoom.Rows[index].Cells[5].Value.ToString();

                lbRoomId.Text = dgvRoom.Rows[index].Cells[0].Value.ToString();
                lbPeople.Text = dgvRoom.Rows[index].Cells[2].Value.ToString();
                lbMoney.Text = dgvRoom.Rows[index].Cells[3].Value.ToString();
                lbDeposited.Text = dgvRoom.Rows[index].Cells[9].Value.ToString();
                txtStart.Text = dgvRoom.Rows[index].Cells[6].Value.ToString();
                txtEnd.Text = dgvRoom.Rows[index].Cells[7].Value.ToString();
<<<<<<< HEAD
                txtUpdateMoney.Text = lbMoney.Text;
=======
>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a
            }

            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.CustomFormat = "HH:mm:ss tt";
            dtpCheckIn.ShowUpDown = true;
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.ShowUpDown = true;
            dtpCheckOut.CustomFormat = "HH:mm:ss tt";


            if (lbId.Text != "")
            {
                //Load database
                var member = DatabaseConnect.db.Members.Where(s => s.idcard == lbId.Text).SingleOrDefault();

                lbPhone.Text = member.phone;
                lbName.Text = member.name;


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
<<<<<<< HEAD

                var room = DatabaseConnect.db.Rooms.Where(s => s.idroom == lbRoomId.Text).SingleOrDefault();
                room.idcard = null;
                room.timeend = null;
                room.timestart = null;
                room.paid = 0;
                room.coupon = 0;
                DatabaseConnect.db.SaveChanges();


=======

                var room = DatabaseConnect.db.Rooms.Where(s => s.idroom == lbRoomId.Text).SingleOrDefault();
                room.idcard = null;
                room.timeend = null;
                room.timestart = null;
                room.paid = 0;
                room.coupon = 0;
                DatabaseConnect.db.SaveChanges();


>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a
                var roomb = DatabaseConnect.db.roombookings.Where(s => s.idroom == lbRoomId.Text).SingleOrDefault();
                DatabaseConnect.db.roombookings.Remove(roomb);
                DatabaseConnect.db.SaveChanges();


                loadData();
            }

        }
        void loadData()
        {
            var lstroom = DatabaseConnect.db.Rooms.ToList();
            dgvRoom.DataSource = lstroom;
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

<<<<<<< HEAD

            var room = DatabaseConnect.db.Rooms.Where(s => s.idroom == lbRoomId.Text).SingleOrDefault();

            room.timeend = dtpCheckOut.Text;
            room.timestart = dtpCheckIn.Text;
=======
>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a

            var room = DatabaseConnect.db.Rooms.Where(s => s.idroom == lbRoomId.Text).SingleOrDefault();

            room.timeend = dtpCheckOut.Text;
            room.timestart = dtpCheckIn.Text;



            var roomb = DatabaseConnect.db.roombookings.Where(s => s.idroom == lbRoomId.Text &&s.@checked==null).SingleOrDefault();

            roomb.checkin = dtpCheckIn.Text;
            roomb.checkout = dtpCheckOut.Text;

<<<<<<< HEAD
            var roomb = DatabaseConnect.db.roombookings.Where(s => s.idroom == lbRoomId.Text && s.@checked == null).SingleOrDefault();

            roomb.checkin = dtpCheckIn.Text;
            roomb.checkout = dtpCheckOut.Text;

=======
>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a
            DatabaseConnect.db.SaveChanges();

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
            FormRoomBooking newform = new FormRoomBooking();
            newform.Show();
        }

        private void txtUpdateMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var room =DatabaseConnect.db.Rooms.Find(lbRoomId.Text);
            room.cash = Int32.Parse(txtUpdateMoney.Text);
            DatabaseConnect.db.SaveChanges();
            loadData();
        }
    }
}
