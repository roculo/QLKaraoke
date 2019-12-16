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
    public partial class FormMenu : Form
    {
        int coca, orange, aqua, chivas, soda, lemon, coconut, beer, sting, juicy, smothy, redwine, rebull = 0, milkcoffe, coffe, watermelo, bull;

        public int total = 0;
        public FormMenu()
        {
            InitializeComponent();
            btnTerminate.Visible = false;
            btnPurchase.Enabled = false;
<<<<<<< HEAD
            lbHiName.Text = "Hello, "+ FormLogin.staffName;
=======

>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a


        }



        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FromMemberRegister newform = new FromMemberRegister();
            newform.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormMemberEdit newform = new FormMemberEdit();
            newform.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FormRoomBook newform = new FormRoomBook();
            newform.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            FormRoomCheck newform = new FormRoomCheck();
            newform.Show();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            FormCheckOut newform = new FormCheckOut();
            newform.Show();
        }


        private void btnCheckk_Click(object sender, EventArgs e)
        {

            try
            {
                btnPurchase.Enabled = true;
                btnTerminate.Visible = true;
                //Open database

                DatabaseConnect.myConn.Open();
                //Load database
                String sql = "select * from member where idcard='" + txtId.Text + "'";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                SqlDataAdapter myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                DataTable myDT = new DataTable();
                myDa.Fill(myDT);
                if (myDT.Rows[0]["idcard"].ToString() == txtId.Text)
                {
                    MessageBox.Show("Ok");
                    btnBook.Enabled = true;
                    txtId.Enabled = false;
                }

                //Close
                DatabaseConnect.myConn.Close();
            }
            catch
            {
                btnPurchase.Enabled = false;
                btnTerminate.Visible = false;
                MessageBox.Show("This Member is not Register yet");
            }
        }
        private void btnListOrder_Click(object sender, EventArgs e)
        {
            ListOrder newform = new ListOrder();
            newform.Show();
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            btnPurchase.Enabled = false;
            txtId.Text = "";
            txtId.Enabled = true;
            btnTerminate.Visible = false;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //open connection

            DatabaseConnect.myConn.Open();
            //excecute command
            if (Convert.ToInt32(Math.Round(nHamberger.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nHamberger.Value, 0)) * 20000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Hamberger" + "'," + 20000 + "," + Convert.ToInt32(Math.Round(nHamberger.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nHamberger.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nMiY.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nMiY.Value, 0)) * 30000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Mi Y" + "'," + 30000 + "," + Convert.ToInt32(Math.Round(nMiY.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nMiY.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nBeak.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nBeak.Value, 0)) * 50000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Beak Steak" + "'," + 50000 + "," + Convert.ToInt32(Math.Round(nBeak.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nBeak.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nChicken.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nChicken.Value, 0)) * 20000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Chicken dries" + "'," + 20000 + "," + Convert.ToInt32(Math.Round(nChicken.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nChicken.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nSoup.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nSoup.Value, 0)) * 20000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Soup" + "'," + 20000 + "," + Convert.ToInt32(Math.Round(nSoup.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nSoup.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nBanhMi.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nBanhMi.Value, 0)) * 25000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Banh Mi Thit" + "'," + 25000 + "," + Convert.ToInt32(Math.Round(nBanhMi.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nBanhMi.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nMiTom.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nMiTom.Value, 0)) * 20000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Mi Ngu Vi" + "'," + 20000 + "," + Convert.ToInt32(Math.Round(nMiTom.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nMiTom.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nGoiCuon.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nGoiCuon.Value, 0)) * 10000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Goi Cuon" + "'," + 10000 + "," + Convert.ToInt32(Math.Round(nGoiCuon.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nGoiCuon.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nComTam.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nComTam.Value, 0)) * 30000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Com Tam" + "'," + 30000 + "," + Convert.ToInt32(Math.Round(nComTam.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nComTam.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nComGa.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nComGa.Value, 0)) * 35000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Com Ga" + "'," + 35000 + "," + Convert.ToInt32(Math.Round(nComGa.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nComGa.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nPizza.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nPizza.Value, 0)) * 180000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Pizza" + "'," + 180000 + "," + Convert.ToInt32(Math.Round(nPizza.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nPizza.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nNem.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nNem.Value, 0)) * 40000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Nem Nuong" + "'," + 40000 + "," + Convert.ToInt32(Math.Round(nNem.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nNem.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nBunThit.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nBunThit.Value, 0)) * 35000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Bun Thit Nuong" + "'," + 35000 + "," + Convert.ToInt32(Math.Round(nBunThit.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nBunThit.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nHuTieu.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nHuTieu.Value, 0)) * 60000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Hu Tieu Nam Vang" + "'," + 60000 + "," + Convert.ToInt32(Math.Round(nHuTieu.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nHuTieu.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nHotDog.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nHotDog.Value, 0)) * 35000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Hot Dog" + "'," + 35000 + "," + Convert.ToInt32(Math.Round(nHotDog.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nHotDog.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nCoCa.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nCoCa.Value, 0)) * 10000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Coca" + "'," + 10000 + "," + Convert.ToInt32(Math.Round(nCoCa.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nCoCa.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nOran.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nOran.Value, 0)) * 12000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Orange" + "'," + 12000 + "," + Convert.ToInt32(Math.Round(nOran.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nOran.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nAqua.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nAqua.Value, 0)) * 7000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Aqua" + "'," + 7000 + "," + Convert.ToInt32(Math.Round(nAqua.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nAqua.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nChivas.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nChivas.Value, 0)) * 350000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Chivas" + "'," + 350000 + "," + Convert.ToInt32(Math.Round(nChivas.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nChivas.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nSoda.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nSoda.Value, 0)) * 20000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Soda" + "'," + 20000 + "," + Convert.ToInt32(Math.Round(nSoda.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nSoda.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nLemon.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nLemon.Value, 0)) * 12000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Lemon" + "'," + 12000 + "," + Convert.ToInt32(Math.Round(nLemon.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nLemon.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nCoconut.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nCoconut.Value, 0)) * 15000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Coconut" + "'," + 15000 + "," + Convert.ToInt32(Math.Round(nCoconut.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nCoconut.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nBeer.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nBeer.Value, 0)) * 17000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Beer" + "'," + 17000 + "," + Convert.ToInt32(Math.Round(nBeer.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nBeer.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nSting.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nSting.Value, 0)) * 10000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Sting" + "'," + 10000 + "," + Convert.ToInt32(Math.Round(nSting.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nSting.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nJuice.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nJuice.Value, 0)) * 22000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Juice" + "'," + 22000 + "," + Convert.ToInt32(Math.Round(nJuice.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nJuice.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nSmoth.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nSmoth.Value, 0)) * 30000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Smothy" + "'," + 30000 + "," + Convert.ToInt32(Math.Round(nSmoth.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nSmoth.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nRed.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nRed.Value, 0)) * 170000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Red Wine" + "'," + 170000 + "," + Convert.ToInt32(Math.Round(nRed.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nRed.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nMilk.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nMilk.Value, 0)) * 12000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Milk Coffe" + "'," + 12000 + "," + Convert.ToInt32(Math.Round(nMilk.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nMilk.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nCoffe.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nCoffe.Value, 0)) * 10000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Coffe" + "'," + 10000 + "," + Convert.ToInt32(Math.Round(nCoffe.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nCoffe.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nWater.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nWater.Value, 0)) * 10000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Water Melon" + "'," + 10000 + "," + Convert.ToInt32(Math.Round(nWater.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nWater.Value = 0;
            }
            if (Convert.ToInt32(Math.Round(nBull.Value, 0)) != 0)
            {
                int value = Convert.ToInt32(Math.Round(nBull.Value, 0)) * 15000;
                String sql = "insert into FoodServices (idcard,foodname,moneyper,number,value,timecall) values ('" + txtId.Text + "','" + "Red Buff" + "'," + 15000 + "," + Convert.ToInt32(Math.Round(nBull.Value, 0)) + "," + value + ",'" + DateTime.Now.ToString() + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                nBull.Value = 0;
            }







            MessageBox.Show("Done!");
            //close connection
            DatabaseConnect.myConn.Close();


        }


        private void nHamberger_ValueChanged(object sender, EventArgs e)
        {
            lbHamberger.Text = "" + Convert.ToInt32(Math.Round(nHamberger.Value, 0)) * 20000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
                + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
                + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nMiY_ValueChanged(object sender, EventArgs e)
        {
            lbMiY.Text = "" + Convert.ToInt32(Math.Round(nMiY.Value, 0)) * 30000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nBeak_ValueChanged(object sender, EventArgs e)
        {
            lbBeaf.Text = "" + Convert.ToInt32(Math.Round(nBeak.Value, 0)) * 50000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nChicken_ValueChanged(object sender, EventArgs e)
        {
            lbChick.Text = "" + Convert.ToInt32(Math.Round(nChicken.Value, 0)) * 20000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nSoup_ValueChanged(object sender, EventArgs e)
        {
            lbSoup.Text = "" + Convert.ToInt32(Math.Round(nSoup.Value, 0)) * 20000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nMiTom_ValueChanged(object sender, EventArgs e)
        {
            lbNoodle.Text = "" + Convert.ToInt32(Math.Round(nMiTom.Value, 0)) * 20000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nBanhMi_ValueChanged(object sender, EventArgs e)
        {
            lbBanhMi.Text = "" + Convert.ToInt32(Math.Round(nBanhMi.Value, 0)) * 25000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nGoiCuon_ValueChanged(object sender, EventArgs e)
        {
            lbGoiCuon.Text = "" + Convert.ToInt32(Math.Round(nGoiCuon.Value, 0)) * 10000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nSting_ValueChanged(object sender, EventArgs e)
        {
            sting = Convert.ToInt32(Math.Round(nSting.Value, 0)) * 10000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nJuice_ValueChanged(object sender, EventArgs e)
        {
            juicy = Convert.ToInt32(Math.Round(nJuice.Value, 0)) * 22000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nSmoth_ValueChanged(object sender, EventArgs e)
        {
            smothy = Convert.ToInt32(Math.Round(nSmoth.Value, 0)) * 30000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nRed_ValueChanged(object sender, EventArgs e)
        {
            redwine = Convert.ToInt32(Math.Round(nRed.Value, 0)) * 170000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nMilk_ValueChanged(object sender, EventArgs e)
        {
            milkcoffe = Convert.ToInt32(Math.Round(nMilk.Value, 0)) * 12000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nCoffe_ValueChanged(object sender, EventArgs e)
        {
            coffe = Convert.ToInt32(Math.Round(nCoffe.Value, 0)) * 12000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void lbMoney_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.qLResortDataSet.Invoice);

        }

        private void btnRecentInvoice(object sender, EventArgs e)
        {
            FormRecentInvoice newform = new FormRecentInvoice();
            newform.Show();
        }

        private void btnDetailInvoice(object sender, EventArgs e)
        {
            FormDetailInvoice newform = new FormDetailInvoice();
            newform.Show();
        }

        private void nWater_ValueChanged(object sender, EventArgs e)
        {
            watermelo = Convert.ToInt32(Math.Round(nWater.Value, 0)) * 10000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPurchase.Enabled = true;
            txtId.Text = cbRoom.Text;
            txtId.Enabled = false;
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            int totalmoney = 0;
            var from = dtpFrom.Value;
            var to = dtpTo.Value;


            var lstResult = DatabaseConnect.db.Invoices.Where(s => s.daycreate == "0").ToList();
            var horizontal = DatabaseConnect.db.Invoices.ToList();
            foreach (var i in horizontal.ToList())
            {
                var date = Convert.ToDateTime(i.daycreate.ToString());
                if (date >= from && date <= to)

                {
                    lstResult.Add(i);
                }

            }


            dgvInvoice.DataSource = lstResult;
            foreach (var i in lstResult.ToList())
            {

                totalmoney = totalmoney + Int32.Parse(i.total.ToString());
            }
            lbTotal.Text = "" + totalmoney.ToString("C");

        }

<<<<<<< HEAD
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FormChangePass newform = new FormChangePass();
            newform.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin newform = new FormLogin();
            newform.Show();
        }

=======
>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a
        private void nBull_ValueChanged(object sender, EventArgs e)
        {
            bull = Convert.ToInt32(Math.Round(nBull.Value, 0)) * 15000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nComTam_ValueChanged(object sender, EventArgs e)
        {
            lbComTam.Text = "" + Convert.ToInt32(Math.Round(nComTam.Value, 0)) * 30000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nComGa_ValueChanged(object sender, EventArgs e)
        {
            lbComGa.Text = "" + Convert.ToInt32(Math.Round(nComGa.Value, 0)) * 35000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nPizza_ValueChanged(object sender, EventArgs e)
        {
            lbPIzaa.Text = "" + Convert.ToInt32(Math.Round(nPizza.Value, 0)) * 180000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nNem_ValueChanged(object sender, EventArgs e)
        {
            lbNemNuong.Text = "" + Convert.ToInt32(Math.Round(nNem.Value, 0)) * 40000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nBunThit_ValueChanged(object sender, EventArgs e)
        {
            lbBunThit.Text = "" + Convert.ToInt32(Math.Round(nBunThit.Value, 0)) * 35000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nHuTieu_ValueChanged(object sender, EventArgs e)
        {
            lbHuTieu.Text = "" + Convert.ToInt32(Math.Round(nHuTieu.Value, 0)) * 60000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nHotDog_ValueChanged(object sender, EventArgs e)
        {
            lbHotdog.Text = "" + Convert.ToInt32(Math.Round(nHotDog.Value, 0)) * 35000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nCoCa_ValueChanged(object sender, EventArgs e)
        {
            coca = Convert.ToInt32(Math.Round(nCoCa.Value, 0)) * 10000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nOran_ValueChanged(object sender, EventArgs e)
        {
            orange = Convert.ToInt32(Math.Round(nOran.Value, 0)) * 12000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nAqua_ValueChanged(object sender, EventArgs e)
        {
            aqua = Convert.ToInt32(Math.Round(nAqua.Value, 0)) * 7000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nChivas_ValueChanged(object sender, EventArgs e)
        {
            chivas = Convert.ToInt32(Math.Round(nChivas.Value, 0)) * 350000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nSoda_ValueChanged(object sender, EventArgs e)
        {
            soda = Convert.ToInt32(Math.Round(nSoda.Value, 0)) * 10000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nLemon_ValueChanged(object sender, EventArgs e)
        {
            lemon = Convert.ToInt32(Math.Round(nLemon.Value, 0)) * 12000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nCoconut_ValueChanged(object sender, EventArgs e)
        {
            coconut = Convert.ToInt32(Math.Round(nCoconut.Value, 0)) * 15000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }

        private void nBeer_ValueChanged(object sender, EventArgs e)
        {
            beer = Convert.ToInt32(Math.Round(nBeer.Value, 0)) * 17000;
            int money = Int32.Parse(lbHamberger.Text) + Int32.Parse(lbMiY.Text) + Int32.Parse(lbBeaf.Text) + Int32.Parse(lbChick.Text) + Int32.Parse(lbSoup.Text) + Int32.Parse(lbNoodle.Text) + Int32.Parse(lbBanhMi.Text) + Int32.Parse(lbGoiCuon.Text) + Int32.Parse(lbComGa.Text)
    + Int32.Parse(lbComTam.Text) + Int32.Parse(lbPIzaa.Text) + Int32.Parse(lbNemNuong.Text) + Int32.Parse(lbHuTieu.Text) + Int32.Parse(lbHotdog.Text) + Int32.Parse(lbBunThit.Text)
    + coca + orange + aqua + chivas + soda + lemon + coconut + beer + sting + juicy + smothy + redwine + rebull + milkcoffe + coffe + watermelo + bull;
            lbMoney.Text = "" + money / 1000 + ",000";
        }
    }
}
