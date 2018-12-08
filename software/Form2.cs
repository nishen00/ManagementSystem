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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            selectattendence();
            selectcregistation();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\New folder\day14\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        void selectattendence()

        {


            con.Open();

            SqlDataAdapter vr = new SqlDataAdapter("SELECT * from ClientAttendence", con);
            DataTable dtre = new DataTable();

            vr.Fill(dtre);

           dgvcattendence.DataSource = dtre;

            con.Close();
        }


        void selectcregistation()
        {


            con.Open();

            SqlDataAdapter vr = new SqlDataAdapter("SELECT * from ClientRegistation", con);
            DataTable dtre = new DataTable();

            vr.Fill(dtre);

            dgvclientregister.DataSource = dtre;

            con.Close();
        }







        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvcattendence_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnempdelete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("TRUNCATE TABLE ClientAttendence", con);
                cmd.ExecuteNonQuery();
                con.Close();
                selectattendence();
            }
            else
            {

            }
        }
    }
}
