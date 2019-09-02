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
    public partial class FormDetailInvoice : Form
    {
        public FormDetailInvoice()
        {
            InitializeComponent();
        }
        int tienroom = 0;
        int tienfood = 0;
        int tienservice = 0;
        int tongtien = 0;


        private void btnFind(object sender, EventArgs e)
        {

            dgvFoodBeverage.Visible = true;
            dgvRoom.Visible = true;
            //Open database

            DatabaseConnect.myConn.Open();
            try
            {
                //Load database Invoice
                String sql = "select * from invoice where idinvoice='" + txtId.Text + "'";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                SqlDataAdapter myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                DataTable myDT = new DataTable();
                myDa.Fill(myDT);
                lbName.Text = myDT.Rows[0]["member"].ToString();
                lbStaff.Text = myDT.Rows[0]["staff"].ToString();
                lbDay.Text = myDT.Rows[0]["daycreate"].ToString();



                //Load database Room
                sql = "select r.idroom,cash,checkin,checkout,r.paid from room r, RoomBooking b where checked=" + txtId.Text + " and r.idroom = b.idroom";
                myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                myDT = new DataTable();
                myDa.Fill(myDT);
                //Load Data into datagridview
                dgvRoom.DataSource = myDT;
                double thanhtienphong = 0;
                int vv = dgvRoom.Rows.Count - 1;
                for (int i = 0; i < vv; i++)
                {

                    double moneyper = Int32.Parse(dgvRoom.Rows[i].Cells[1].Value.ToString());
                    double paid = Int32.Parse(dgvRoom.Rows[i].Cells[4].Value.ToString());
                    DateTime dt = Convert.ToDateTime(dgvRoom.Rows[i].Cells[2].Value.ToString());
                    DateTime dt2 = Convert.ToDateTime(dgvRoom.Rows[i].Cells[3].Value.ToString());
                    TimeSpan dt3 = dt2 - dt;
                    double totalday = dt3.TotalDays;
                    thanhtienphong += totalday * moneyper - paid;

                }
                lbMoneyRoom.Text = "" + thanhtienphong.ToString("C");



                //Load database Food and Beverage
                sql = "select * from foodservices where checked=" + txtId.Text;
                myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                myDT = new DataTable();
                myDa.Fill(myDT);
                //Load Data into datagridview
                dgvFoodBeverage.DataSource = myDT;
                int sc = dgvFoodBeverage.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < sc - 1; i++)
                    thanhtien += float.Parse(dgvFoodBeverage.Rows[i].Cells["value"].Value.ToString());
                lbMoneyFood.Text = "" + thanhtien.ToString("C");


                //Load Data into datagridview

                double total = thanhtienphong + thanhtien;

                // bien an
                tienroom = (int)thanhtienphong;
                tienfood = (int)thanhtien;
                tongtien = tienfood + tienroom + tienservice;

                lbTotal.Text = "" + total.ToString("C");
                //Close
                DatabaseConnect.myConn.Close();
                lbDay.Visible = true;
                lbMoneyFood.Visible = true;
                lbMoneyRoom.Visible = true;
                lbName.Visible = true;
                lbStaff.Visible = true;
                lbTotal.Visible = true;
                dgvFoodBeverage.Visible = true;
                dgvRoom.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
            }
            catch
            {
                lbDay.Visible = false;
                lbMoneyFood.Visible = false;
                lbMoneyRoom.Visible = false;
                lbName.Visible = false;
                lbStaff.Visible = false;
                lbTotal.Visible = false;
                dgvFoodBeverage.Visible = false;
                dgvRoom.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                MessageBox.Show("Invalid Invoice Number");
            }
        }


        private void FormDetailInvoice_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.FoodServices' table. You can move, or remove it, as needed.
            this.foodServicesTableAdapter.Fill(this.qLResortDataSet.FoodServices);

        }
    }
}

