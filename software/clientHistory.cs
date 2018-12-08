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
    public partial class clientHistory : Form
    {
        public clientHistory()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\New folder\day14\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientHistory_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter v = new SqlDataAdapter("SELECT * from ClientHistory", con);
            DataTable dtr = new DataTable();

            v.Fill(dtr);

            dataGridView1.DataSource = dtr;

            con.Close();
        }

        string Gender;
        String paymentNot;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("select * from ClientHistory", con);

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);


                txtclientName.Text = table.Rows[e.RowIndex][2].ToString();
                txtcaddrees.Text = table.Rows[e.RowIndex][3].ToString();
                txtcnic.Text = table.Rows[e.RowIndex][4].ToString();
                txtcphone.Text = table.Rows[e.RowIndex][5].ToString();
                dtpcbirth.Text = table.Rows[e.RowIndex][6].ToString();
                Gender = table.Rows[e.RowIndex][7].ToString();
                if (Gender == "MALE")
                {
                    rdoMale.Checked = true;
                }
                if (Gender == "FEMAIL")
                {
                    rdoFemale.Checked = true;
                }
                cmbcdrug.Text = table.Rows[e.RowIndex][8].ToString();

                cmbccounciller.Text = table.Rows[e.RowIndex][9].ToString();
                txtcjob.Text = table.Rows[e.RowIndex][10].ToString();
                txtcguardian.Text = table.Rows[e.RowIndex][11].ToString();
                paymentNot = table.Rows[e.RowIndex][13].ToString();
                if (paymentNot == "PAYMENT")
                {
                    rdopayment.Checked = true;
                }
                if (paymentNot == "NO_PAYMENT")
                {
                    rdonunpayment.Checked = true;
                }
            }
            catch (Exception en)
            {
                MessageBox.Show("Please select correct data row that the datas are added");
            }


        }
    }
}
