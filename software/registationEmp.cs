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
    public partial class registationEmp : Form
    {
        string imglocation;
        public registationEmp(string i1)
        {
            InitializeComponent();
            imglocation = i1;
            
            

            typecombo();
            qualificationcombo();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\New folder\day14\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

       



        












       
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        void typecombo()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\New folder\day14\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select name from EmployeeType", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                cmbemptype.Items.Add(dr["Name"].ToString());
            }


            con.Close();


        }

        void qualificationcombo()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\New folder\day14\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select name from EmployeeQualification", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                cmbempquali.Items.Add(dr["Name"].ToString());
            }


            con.Close();


        }


        void select()
        {


            con.Open();

            SqlDataAdapter vr = new SqlDataAdapter("SELECT * from EmployeeRegistation", con);
            DataTable dtre = new DataTable();

            vr.Fill(dtre);

           dgvempreg.DataSource = dtre;

            con.Close();
        }


       







        private void registationEmp_Load(object sender, EventArgs e)
        {
            btnempdelete.Enabled = false;
            btnupdate.Enabled = false;
            txtage.Enabled = false;
               
            pnlfullname.Hide();
            pnlNic.Hide();
            pnlAge.Hide();
            pnlgender.Hide();
            pnlphoneno.Hide();
            pnlemptype.Hide();
            pnlAddress.Hide();
            pnlqualification.Hide();

            pictureBox1.ImageLocation = imglocation;
            select();
            


           
           
        }
        public string empGuid;
        private void btnempreg_Click(object sender, EventArgs e)
        {

            string newguid = System.Guid.NewGuid().ToString().Replace("-", "");

            empGuid = newguid;


            if (txtempname.Text == "" || txtempnic.Text == "" || txtaddrees.Text == "" || txtage.Text == "" || rdoFemale.Checked == false && rdoMale.Checked == false || txtphone.Text == "" || cmbemptype.Text == "" || cmbempquali.Text == "")
            {

                MessageBox.Show("Please check the registation form again, you have some mistakes");

                if (txtempname.Text == "")
                {
                    pnlfullname.Show();

                }
                if (txtempnic.Text == "")
                {
                    pnlNic.Show();

                }
                if (txtaddrees.Text == "")
                {
                    pnlAddress.Show();
                }
                if (txtage.Text == "")
                {
                    pnlAge.Show();
                }
                if (rdoMale.Checked == false && rdoFemale.Checked == false)
                {
                    pnlgender.Show();
                }
                if (txtphone.Text == "")
                {
                    pnlphoneno.Show();

                }
                if (cmbemptype.Text == "")
                {
                    pnlemptype.Show();
                }
                if (cmbempquali.Text == "")
                {
                    pnlqualification.Show();
                }

            }


            else
            {

                string empId = System.Guid.NewGuid().ToString().Replace("-", "");

                


                byte[] images = null;

                FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);

                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeRegistation(EmpID,EmpName,NIC,Address,Birthday,Age,EmployeeType,Qualification,Gender,PhoneNumber,EmpPhoto,JoinDate)VALUES('" +empId + "','" +txtempname.Text + "','" + txtempnic.Text + "','" + txtaddrees.Text + "','" + dtpempbirth.Text + "','" + txtage.Text + "','" + cmbemptype.Text + "','" + cmbempquali.Text+ "','" + Gender + "','" + txtphone.Text + "',@images,'" + dtpempjoin.Text + "')", con);




                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("INSERTED");

                select();

                txtempname.Text = "";
                txtempnic.Text = "";
                txtaddrees.Text = "";
                txtage.Text = "";
                cmbemptype.Text = "";
                cmbempquali.Text = "";
                rdoMale.Checked = false;
                rdoFemale.Checked = false;
                txtphone.Text = "";


            }



        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnface_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtempname_Leave(object sender, EventArgs e)
        {
            if (txtempname.Text == "")
            {
                pnlfullname.Show();
            }
            else
            {
                pnlfullname.Hide();
            }




        }

        private void txtempnic_Leave(object sender, EventArgs e)
        {
            if (txtempnic.Text == "")
            {
                pnlNic.Show();
            }
            else
            {
                pnlNic.Hide();
            }
        }

        private void txtaddrees_Leave(object sender, EventArgs e)
        {
            if (txtaddrees.Text == "")
            {
                pnlAddress.Show();
            }
            else
            {
                pnlAddress.Hide();

            }
        }

        private void txtage_Leave(object sender, EventArgs e)
        {
            if (txtage.Text == "")
            {
                pnlAge.Show();
            }
            else
            {
                pnlAge.Hide();
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "")
            {
                pnlphoneno.Show();
            }
            else
            {
                pnlphoneno.Hide();
            }
        }

        private void rdoFemale_Click(object sender, EventArgs e)
        {
            pnlgender.Hide();
        }

        private void rdoMale_Click(object sender, EventArgs e)
        {
            pnlgender.Hide();
        }

        private void cmbemptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlemptype.Hide();
        }

        private void cmbempquali_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlqualification.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        string Gender;

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        string empIdentify;

        private void dgvempreg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnempdelete.Enabled = false;
                btnupdate.Enabled = true;

                btnempreg.Enabled = false;
                SqlCommand cmd = new SqlCommand("select * from EmployeeRegistation", con);

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);


                empIdentify = table.Rows[e.RowIndex][0].ToString();


                byte[] img = (byte[])table.Rows[e.RowIndex][11];
                txtempname.Text = table.Rows[e.RowIndex][2].ToString();
                txtempnic.Text = table.Rows[e.RowIndex][3].ToString();
                txtaddrees.Text = table.Rows[e.RowIndex][4].ToString();
                dtpempbirth.Text = table.Rows[e.RowIndex][5].ToString();
                txtage.Text = table.Rows[e.RowIndex][6].ToString();
                cmbemptype.Text = table.Rows[e.RowIndex][7].ToString();
                cmbempquali.Text = table.Rows[e.RowIndex][8].ToString();
                Gender = table.Rows[e.RowIndex][9].ToString();
                if (Gender == "Male")
                {
                    rdoMale.Checked = true;
                }
                else if (Gender == "Female")
                {
                    rdoFemale.Checked = true;
                }
                txtphone.Text = table.Rows[e.RowIndex][10].ToString();
                dtpempjoin.Text = table.Rows[e.RowIndex][12].ToString();

                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                da.Dispose();
            }
            catch (Exception er)
            {
                MessageBox.Show("Please select correct data row that the datas are added");

            }
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            

           
        }

        private void dgvempreg_Leave(object sender, EventArgs e)
        {
           
        }

        private void btnempdelete_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are you sure ";
                       string caption = "Error Detected in Input";
		MessageBoxButtons buttons = MessageBoxButtons.YesNo;
		DialogResult result;

		// Displays the MessageBox.

		result = MessageBox.Show(message, caption, buttons);

        if (result == System.Windows.Forms.DialogResult.Yes)
        {


            SqlCommand cmd = new SqlCommand("delete from EmployeeRegistation where EmpID ='" + empIdentify + "' ", con);
            SqlDataReader datare;

            con.Open();

            datare = cmd.ExecuteReader();
            MessageBox.Show("Deleted");

            con.Close();

            select();
        }
        
               
            }
            catch (Exception et)
            {
                MessageBox.Show("Error");
            }

        }

        

        private void dtpempbirth_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void dtpempbirth_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void dtpempbirth_Leave(object sender, EventArgs e)
        {
            int birthyear;
            birthyear = dtpempbirth.Value.Year;

            String todayyear = DateTime.Today.ToString("yyyy");

            int today = Convert.ToInt32(todayyear);

            int age = today - birthyear;

            txtage.Text = Convert.ToString(age);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
                string message = "Are you sure ";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {


                    SqlCommand cmd = new SqlCommand("update EmployeeRegistation set EmpName='"+txtempname.Text+"',NIC='"+txtempnic.Text+"',Address='"+txtaddrees.Text+"',Birthday='"+dtpempbirth.Text+"',Age='"+txtage.Text+"',EmployeeType='"+cmbemptype.Text+"',Qualification='"+cmbempquali.Text+"',Gender='"+Gender+"',PhoneNumber='"+txtphone.Text+"',JoinDate='"+dtpempjoin.Text+"' where EmpID='"+empIdentify+"'", con);
                    SqlDataReader datare;

                    con.Open();

                    datare = cmd.ExecuteReader();
                    MessageBox.Show("Updated");

                    con.Close();

                    select();
                }


            
            
        }

        private void dgvempreg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
