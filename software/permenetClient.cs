using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace MultiFaceRec
{
    public partial class permenetClient : Form
    {
        public permenetClient()
        {
            InitializeComponent();
            selectClient3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\New folder\day14\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        string vr = "NO_PAYMENT";


        void selectClient3()
        {
            con.Open();

            SqlDataAdapter v = new SqlDataAdapter("SELECT * from ClientRegistation where PaymentOrNot ='" +vr + "' ", con);
            DataTable dtr = new DataTable();

            v.Fill(dtr);

            dgvclientshow.DataSource = dtr;

            con.Close();





        }

        private void permenetClient_Load(object sender, EventArgs e)
        {
            btnhomenondis.Enabled = false;
        }
        string clientid3;

        private void dgvclientshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnhomenondis.Enabled = true;
            string gen;
            string pay;
            try
            {
                SqlCommand cmd = new SqlCommand("select * from ClientRegistation", con);

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                clientid3 = table.Rows[e.RowIndex][0].ToString();

                byte[] img = (byte[])table.Rows[e.RowIndex][17];
                txthomecname.Text = table.Rows[e.RowIndex][2].ToString();
                txthomeaddress.Text = table.Rows[e.RowIndex][3].ToString();
                txthomeNIC.Text = table.Rows[e.RowIndex][4].ToString();
                txthomephone.Text = table.Rows[e.RowIndex][5].ToString();
                dtphomecbirthday.Text = table.Rows[e.RowIndex][6].ToString();
                gen = table.Rows[e.RowIndex][7].ToString();

                if (gen == "MALE")
                {
                    rdohomemale.Checked = true;
                }
                else if (gen == "FEMALE")
                {
                    rdohomefemale.Checked = true;
                }

                cmbhomedrug.Text = table.Rows[e.RowIndex][8].ToString();
                cmbhomecounciller.Text = table.Rows[e.RowIndex][9].ToString();
                txthomejob.Text = table.Rows[e.RowIndex][10].ToString();
                txthomeguardian.Text = table.Rows[e.RowIndex][11].ToString();
                pay = table.Rows[e.RowIndex][13].ToString();

                if (pay == "PAYMENT")
                {
                    rdohomepayment.Checked = true;
                }
                else if (pay == "NO_PAYMENT")
                {
                    rdohomenunpayment.Checked = true;
                }

                MemoryStream ms = new MemoryStream(img);
                pictureBoxhomeclient.Image = Image.FromStream(ms);
                da.Dispose();









            }

            catch (Exception ety)
            {

                MessageBox.Show("Please select correct data row that the datas are added");
            }
        }

        private void btnhomenondis_Click(object sender, EventArgs e)
        {


            string date = DateTime.Today.ToString("yyyy/MM/dd");
            SqlCommand cmd = new SqlCommand("INSERT INTO ClientHistory(ClientID,FullName,Address,NIC,PhoneNumber,Birthday,Gender,MainDrug,Job,GuardianName,PaymentOrNot,DischargeDate)VALUES('" + clientid3 + "','" + txthomecname.Text + "','" + txthomeaddress.Text + "','" + txthomeNIC.Text + "','" + txthomephone.Text + "','" + dtphomecbirthday.Text + "','" + gender2 + "','" + cmbhomedrug.Text + "','" + txthomejob.Text + "','" + txthomeguardian.Text + "','" + paytype + "','" + date + "')", con);

            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Update client History");


            SqlCommand cmd2 = new SqlCommand("delete from ClientRegistation where ClientID ='" + clientid3 + "' ", con);
            SqlDataReader datare;

            con.Open();

            datare = cmd2.ExecuteReader();
            MessageBox.Show("client record Deleted");

            con.Close();

            selectClient3();
        }
        string gender2;
        private void rdohomemale_Click(object sender, EventArgs e)
        {
           
        }

        private void rdohomemale_CheckedChanged(object sender, EventArgs e)
        {
            gender2 = "MALE";
        }

        private void rdohomefemale_Click(object sender, EventArgs e)
        {
            gender2 = "FEMALE";
        }


        string paytype;

        private void rdohomepayment_CheckedChanged(object sender, EventArgs e)
        {
            paytype = "PAYMENT";
        }

        private void rdohomenunpayment_CheckedChanged(object sender, EventArgs e)
        {
            paytype = "NO_PAYMENT";
        }
    }
}
