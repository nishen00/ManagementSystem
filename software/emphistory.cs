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
    public partial class emphistory : Form
    {
        public emphistory()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\New folder\day14\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        void select()
        {


            con.Open();

            SqlDataAdapter vr = new SqlDataAdapter("SELECT * from EmployeeHistory", con);
            DataTable dtre = new DataTable();

            vr.Fill(dtre);

            dgvempsearch.DataSource = dtre;

            con.Close();
        }

        private void emphistory_Load(object sender, EventArgs e)
        {
            select();
        }

        private void dgvempsearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("select * from EmployeeHistory", con);

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);





                byte[] img = (byte[])table.Rows[e.RowIndex][11];
                txtempname.Text = table.Rows[e.RowIndex][2].ToString();
                txtempnic.Text = table.Rows[e.RowIndex][3].ToString();
                txtaddrees.Text = table.Rows[e.RowIndex][4].ToString();
                txtbirthday.Text = table.Rows[e.RowIndex][5].ToString();
                txtage.Text = table.Rows[e.RowIndex][6].ToString();
                txtemptype.Text = table.Rows[e.RowIndex][7].ToString();
                txtquali.Text = table.Rows[e.RowIndex][8].ToString();
                txtgender.Text = table.Rows[e.RowIndex][9].ToString();

                txtphone.Text = table.Rows[e.RowIndex][10].ToString();
                txtjoindate.Text = table.Rows[e.RowIndex][12].ToString();

                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                da.Dispose();

                


             



            }
            catch (Exception er)
            {
                MessageBox.Show("Please select correct data row that the datas are added");

            }
        }
    }
}
