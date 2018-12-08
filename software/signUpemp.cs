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
    
    public partial class signUpemp : Form
    {
        string empid;
        public signUpemp(string id)
        {
            InitializeComponent();
            empid = id;
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\New folder\day14\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");


        private void signUpemp_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from EmployeeRegistation where EmpID='"+empid+"'",con);
            DataTable dt = new DataTable();

            SqlDataAdapter adt = new SqlDataAdapter(cmd);

            adt.Fill(dt);
            byte[] img = (byte[])dt.Rows[0][11];

            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

            adt.Dispose();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void txtempqName_Leave(object sender, EventArgs e)
        {
            

       

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtspassword_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtrepassword_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtNic_Click(object sender, EventArgs e)
        {
           
        }

        private void txtsUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void txtspassword_Click(object sender, EventArgs e)
        {
            
        }

        private int numpass(string pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    num++;
                }
            }
            return num;
        }

        private int upperCase(string pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsUpper(ch))
                {
                    num++;
                }
            }
            return num;

        }

        private void txtrepassword_Click(object sender, EventArgs e)
        {
            
        }
        string empNic;
        string empType;

        private void btnempreg_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand c = new SqlCommand("select * from EmployeeRegistation where EmpID='" +empid + "'", con);

            SqlDataReader m;

            m = c.ExecuteReader();


            if (m.Read())
            {
                 empNic= (m["NIC"].ToString());


               
            }
            else
            {
                MessageBox.Show("There is no data");
            }



            con.Close();



            if (txtNic.Text == "" || txtsUsername.Text == "" || txtspassword.Text == "" || txtrepassword.Text == "" || txtNic.Text != empNic ||( txtspassword.Text.Length < 6 && numpass(txtspassword.Text) < 1 && upperCase(txtspassword.Text) < 1)||txtspassword.Text!=txtrepassword.Text)
            {
                

                
                    if (txtspassword.Text.Length < 6 && numpass(txtspassword.Text) < 1 && upperCase(txtspassword.Text) < 1)
                    {
                        lblerror.Text = "Password should be minimum 6 letters and 1 number and 1 uppercase letter";
                    }
                    
                
                else
                {
                    
                    lblerror.Text = "";
                    MessageBox.Show("Check the form again");
                }
               

               
            }
            else
            {
                SqlDataAdapter adt = new SqlDataAdapter("select count(*) from Login where PassWord='"+txtspassword.Text+"'",con);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    lblerror.Text = "Cannot use this PassWord";
                }
                else
                {
                    con.Open();
                    SqlCommand cmde = new SqlCommand("select * from EmployeeRegistation where EmpID ='" + empid + "'", con);

                    SqlDataReader dr;


                    dr = cmde.ExecuteReader();


                    if (dr.Read())
                    {
                        empType = (dr["EmployeeType"].ToString());



                    }
                    else
                    {
                        MessageBox.Show("There is no data");
                    }



                    con.Close();


                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Login(EmpPID,UserName,PassWord,Type)VALUES('" + empid + "','" + txtsUsername.Text + "','" + txtspassword.Text + "','" + empType + "')", con);



                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Account is created");

                    con.Close();

                }

               
            }
        }
    }
}
