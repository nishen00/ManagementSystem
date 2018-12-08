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
    public partial class EmpLeft : Form
    {
        public EmpLeft()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\New folder\day14\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void EmpLeft_Load(object sender, EventArgs e)
        {

            select();
        }

        void select()
        {
            con.Open();

            SqlDataAdapter vr = new SqlDataAdapter("SELECT * from EmployeeRegistation", con);
            DataTable dtre = new DataTable();

            vr.Fill(dtre);

            dgvempsearch.DataSource = dtre;

            con.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string empid2;

        private void dgvempsearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from EmployeeRegistation", con);

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);





                byte[] img = (byte[])table.Rows[e.RowIndex][11];
                empid2 = table.Rows[e.RowIndex][0].ToString();
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


                con.Close();




            }
            catch (Exception er)
            {
                MessageBox.Show("Please select correct data row that the datas are added");

            }

        }
        string imglocation = "E:\\New folder\\day14\\New folder\\software\\Resources\\facebook-silhouette.jpg";


        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from Login where EmpPID ='" +empid2 + "' ", con);
            SqlDataReader datare;

            

            datare = cmd.ExecuteReader();
            MessageBox.Show("Login permission is removed");

            con.Close();



             byte[] images = null;

                FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);
           

            con.Open();

            SqlCommand bmd = new SqlCommand("INSERT INTO EmployeeHistory (EmpID,EmpName,NIC,Address,Birthday,Age,EmployeeType,Qualification,Gender,PhoneNumber,EmpPhoto,JoinDate)VALUES('" + empid2 + "','" + txtempname.Text + "','" + txtempnic.Text + "','" + txtaddrees.Text + "','" + txtbirthday.Text + "','" + txtage.Text + "','" +txtemptype.Text + "','" + txtquali.Text + "','" + txtgender.Text + "','" + txtphone.Text + "',@images,'" + txtjoindate.Text + "')", con);



             bmd.Parameters.Add(new SqlParameter("@images", images));
            
            bmd.ExecuteNonQuery();
            MessageBox.Show("History table Updated");
            con.Close();




            con.Open();

            SqlCommand pd = new SqlCommand("delete from EmployeeRegistation where EmpID ='" + empid2 + "' ", con);
            SqlDataReader dar;



            dar = pd.ExecuteReader();
            MessageBox.Show("Compleded task");

            con.Close();

            select();

            

        }
    }
}
