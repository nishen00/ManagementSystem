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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string bh = "";
        string type = "//";

        int value;
        private void button1_Click_1(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\my project\drugs control board\day14\Dcsd-ka-171\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Type from Login where UserName='"+txtusername.Text+"'and PassWord='"+txtpassword.Text+"'",con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                string b1;

                b1 = dt.Rows[0][0].ToString();

                if (b1 == "maneger")
                {
                    value = 1;
                }
                else if (b1== "counsiler")
                {
                    value = 2;
                }
                else if (b1 == "Data Entry")
                {
                    value = 3;
                }
                else
                {
                    value = 4;
                }
               

                Home b = new Home(bh, type,value);
                b.ShowDialog();
                this.Hide();

            }
            else
            {
                label3.Text = "Wrong UserName Password";
            }




            
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
