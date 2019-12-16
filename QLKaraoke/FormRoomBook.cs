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
    public partial class FormRoomBook : Form
    {

        public FormRoomBook()
        {
            InitializeComponent();
            btnBook.Enabled = false;
            rbnNormal.Checked = true;
            rbnPeople2.Checked = true;
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "HH:mm:ss tt";
            dtpStart.ShowUpDown = true;

            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.ShowUpDown = true;
            dtpEnd.CustomFormat = "HH:mm:ss tt";


        }
        int people = 1;

        private void btnCheck_Click(object sender, EventArgs e)
        {


            if (DatabaseConnect.db.Members.Any(s => s.idcard == txtId.Text))
            {
                MessageBox.Show("Ok");
                btnBook.Enabled = true;
                txtId.Enabled = false;
            }
            else
            {
                MessageBox.Show("This Member is not Register yet");
            }




        }



        private void btnBook_Click(object sender, EventArgs e)
        {
            String type = "";
            if (rbnVip.Checked)
                type = "Vip";
            else
                type = "Normal";

            String finish = dtpEnd.Text;
            if (dtpStart.Text == dtpEnd.Text)
            {
                finish = "";
            }



            String sql = "select idroom from Room where type='" + type + "' and people=" + people + " and idcard is NULL ";
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            SqlDataAdapter myDa = new SqlDataAdapter();
            myDa.SelectCommand = myCommand;
            DataTable myDT = new DataTable();
            myDa.Fill(myDT);
            try
            {
                DateTime now = DateTime.Today;
                DateTime checkin = DateTime.Parse(dtpStart.Text);
                DateTime checkout = DateTime.Parse(dtpEnd.Text);


                if (now.Day == checkin.Day)//dat trong ngay
                {
                    DatabaseConnect.myConn.Open();
                    MessageBox.Show(myDT.Rows[0]["idroom"].ToString());
                    String roomid = myDT.Rows[0]["idroom"].ToString();
                    if (txtId.Text == "Guest")
                    {
                        txtId.Text = myDT.Rows[0]["idroom"].ToString();
                    }
                    int deposite = Convert.ToInt32(Math.Round(numDeposite.Value, 0));
                    sql = "update Room set idcard='" + txtId.Text + "',timestart='" + dtpStart.Text + "',timeend='" + finish + "',paid=" + deposite + ",coupon=0 where idroom='" + roomid + "'";
                    String asql = "insert into roombooking(idroom,idcard,checkin,checkout,paid) values('" + roomid + "','" + txtId.Text + "','" + dtpStart.Text + "','" + finish + "'," + deposite + ") ";
                    myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                    myCommand.ExecuteNonQuery();
                    myCommand = new SqlCommand(asql, DatabaseConnect.myConn);
                    myCommand.ExecuteNonQuery();
                    //close connection
                    DatabaseConnect.myConn.Close();
                    //load again datagriview
                    MessageBox.Show("Now Complete");
                    this.Close();
                }

                else
                {

                    sql = "select distinct b.idroom,checkin,checkout,r.paid from RoomBooking b, room r where r.type = '" + type + "' and people = " + people + " order by idroom desc";
                    String cont = "a"; String end = "b";
                    myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                    myDa = new SqlDataAdapter();
                    myDa.SelectCommand = myCommand;
                    myDT = new DataTable();
                    myDa.Fill(myDT);

                    for (int i = 0; i < myDT.Rows.Count; i++)
                    {
                        if (cont == myDT.Rows[i]["idroom"].ToString())
                            continue;
                        DateTime checkoutpre = DateTime.Parse(myDT.Rows[i]["checkout"].ToString());


                        if (checkin > checkoutpre)
                        {
                            MessageBox.Show("" + myDT.Rows.Count);
                            string sqldo = "insert into roombooking(idroom,idcard,checkin,checkout,paid) values('" + myDT.Rows[i]["idroom"].ToString() + "','" + txtId.Text + "','" + dtpStart.Text + "','" + dtpEnd.Text + "'," + myDT.Rows[i]["paid"].ToString() + ") ";
                            myCommand = new SqlCommand(sqldo, DatabaseConnect.myConn);
                            myCommand.ExecuteNonQuery();
                            //load again datagriview
                            MessageBox.Show("checking complete");
                            end = "good";
                            break;
                        }
                        cont = myDT.Rows[i]["idroom"].ToString();
                    }
                    DatabaseConnect.myConn.Close();
                    if (end != "good")
                    {
                        MessageBox.Show("Out Of This Room That Day");
                    }
                    else
                    {
                        this.Close();
                    }


                }
            }
            catch
            {
                MessageBox.Show("Out of Room");
            }

        }

        private void rbnPeople1_CheckedChanged(object sender, EventArgs e)
        {
            people = 4;
        }

        private void rbnPeople2_CheckedChanged(object sender, EventArgs e)
        {
            people = 8;
        }



        private void rbnPeople4_CheckedChanged(object sender, EventArgs e)
        {
            people = 15;
        }
        private void rbnPeople8_CheckedChanged(object sender, EventArgs e)
        {
            people = 24;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbnNewGuest_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Text = "Guest";
            txtId.Enabled = false;
            btnBook.Enabled = true;
        }
    }
}
