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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace MultiFaceRec
{
    public partial class Home : Form
    {
        string ty12;

        int typerec;
        public Home( string image55,string type,int type2 )
        {
            InitializeComponent();
            imagelocation3 = image55;
            ty12 = type;
            selectClient();
            selectClient3();
            typerec = type2;
            typecombo2();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\my project\drugs control board\day14\Dcsd-ka-171\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        string EmpQID = "EQ";
        



        string emptID = "ET";


        void selectClient()
        {
            con.Open();

            SqlDataAdapter v = new SqlDataAdapter("SELECT * from ClientRegistation", con);
            DataTable dtr = new DataTable();

            v.Fill(dtr);

            dgvclient.DataSource = dtr;

            con.Close();



            

        }

        void selectClient2()
        {
            con.Open();

            SqlDataAdapter v = new SqlDataAdapter("SELECT * from ClientRegistation", con);
            DataTable dtr = new DataTable();

            v.Fill(dtr);

            ggvClient.DataSource = dtr;

            con.Close();





        }

        string totaydate = DateTime.Today.ToString("yyyy-MM-dd");

        void selectClient3()
        {
            con.Open();

            SqlDataAdapter v = new SqlDataAdapter("SELECT * from ClientRegistation where DischargeDate='"+totaydate+"' ", con);
            DataTable dtr = new DataTable();

            v.Fill(dtr);

            dgvclientshow.DataSource = dtr;

            con.Close();





        }



        private void empqid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(EmpQID) from EmployeeQualification", con);

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            i++;
            lblqid.Text = EmpQID + i.ToString();

        }

        private void empTypeID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(TypeID) from EmployeeType", con);

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            i++;
            lblemptypeid.Text = emptID + i.ToString();

        }

        string emptype2 = "counsiler";
        void typecombo()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\my project\drugs control board\day14\Dcsd-ka-171\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select EmpName from EmployeeRegistation where EmployeeType ='"+emptype2+"' ", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                cmbccounciller.Items.Add(dr["EmpName"].ToString());
            }


            con.Close();


        }






        int empq;
        private void empdel()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(DelID) from EmployeeQualification", con);

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            i++;
            empq = i;

        }




        int emptypede;
        private void emptypedel()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(TDelID) from EmployeeType", con);

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            i++;
            emptypede = i;
            

        }

       

        private void Home_Load(object sender, EventArgs e)
        {
            if (typerec == 2)
            {

                btnemp.Enabled = false;
                btnsignup.Enabled = false;
                btnsetting.Enabled = false;

            }

            if (typerec == 1)
            {
                btnemp.Enabled = true;
                btnsignup.Enabled = true;


            }
            if (typerec == 3)
            {
                btnemp.Enabled = false;
                btnsignup.Enabled = false;
                btnsetting.Enabled = false;

            }






            
            grppayment.Hide();
            pnlCsName.Hide();
            selectClient2();
            pictureBox5.ImageLocation = imagelocation3;
            btncupdate.Enabled = false;
            btncdelete.Enabled = false;

            txtclientName.Enabled = false;
            txtcaddrees.Enabled = false;
            txtcnic.Enabled = false;
            txtcphone.Enabled = false;
            dtpcbirth.Enabled = false;
            cmbcdrug.Enabled = false;
            cmbccounciller.Enabled = false;
            txtcjob.Enabled = false;
            txtcguardian.Enabled = false;
            groupBox11.Enabled = false;

            if (ty12 == "done")
            {

                txtclientName.Enabled = true;
                txtcaddrees.Enabled = true;
                txtcnic.Enabled = true;
                txtcphone.Enabled = true;
                dtpcbirth.Enabled = true;
                cmbcdrug.Enabled = true;
                cmbccounciller.Enabled = true;
                txtcjob.Enabled = true;
                txtcguardian.Enabled = true;
                groupBox11.Enabled = true;
            }

            pnlfullname.Hide();
            pnlcNic.Hide();
            pnlcaddress.Hide();
            pnlcPhone.Hide();
            pnlcGender.Hide();

            pnlcDrug.Hide();
            pnlccounciller.Hide();
            pnlcJob.Hide();
            pnlcGuardian.Hide();
            pnlrdopaymentorNon.Hide();
            
            pnlcPay.Hide();

            pictureBox5.ImageLocation = imagelocation3;


           



                        empqid();
                        empdel();
                        pnlPayment.Hide();

                        empTypeID();

                        emptypedel();
                        pnlempqvali.Hide();
                        pnlemptype.Hide();


                        con.Open();

                        SqlDataAdapter v = new SqlDataAdapter("SELECT * from EmployeeQualification", con);
                        DataTable dtr = new DataTable();

                        v.Fill(dtr);

                        dgvempsetting.DataSource = dtr;

                        con.Close();

            

                        con.Open();

                        SqlDataAdapter vr = new SqlDataAdapter("SELECT * from EmployeeType", con);
                        DataTable dtre = new DataTable();

                        vr.Fill(dtre);

                        dgvemptype.DataSource = dtre;

                        con.Close();




                        con.Open();

                        SqlDataAdapter vr2 = new SqlDataAdapter("SELECT * from DrugType", con);
                        DataTable dtre2 = new DataTable();

                        vr2.Fill(dtre2);

                        dgvClientS.DataSource = dtre2;

                        con.Close();
            
            



        }
        void typecombo2()

        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\my project\drugs control board\day14\Dcsd-ka-171\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select Name from DrugType", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

               cmbcdrug.Items.Add(dr["Name"].ToString());
            }


            con.Close();


        }




        private void btnhome_Click(object sender, EventArgs e)
        {
            sidepanal.Top = btnhome.Top;
            pnlHome.Show();
            selectClient3();
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            sidepanal.Top =btnemp.Top;
            pnlemp.Show();
            pnlempsetting.Hide();
            pnlclient.Hide();
            pnlClientSetting.Hide();
            pnlHome.Hide();
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
           
            sidepanal.Top =btnclient.Top;
            pnlclient.Show();
            typecombo();
            pnlClientSetting.Hide();
            selectClient2();
            pnlHome.Hide();
            selectClient3();
            selectClient();
        }

        string signface;

        private void btnsignup_Click(object sender, EventArgs e)
        {
            sidepanal.Top =btnsignup.Top;
            signface = "faceds";
            FrmPrincipal b = new FrmPrincipal(signface);
            b.ShowDialog();

        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            sidepanal.Top =btnsetting.Top;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlempsetting.Show();
            pnlclient.Hide();
            pnlHome.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtempqName.Text == "")
            {
                pnlempqvali.Show();

            }
            else
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeQualification(EmpQID,Name,AddedDate,DelID)VALUES('" + lblqid.Text + "','" + txtempqName.Text + "','" + dtpempq.Text + "','" + empq + "')", con);

                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("INSERTED");
                empqid();
                empdel();

                con.Open();

                SqlDataAdapter adt = new SqlDataAdapter("SELECT * from EmployeeQualification", con);
                DataTable dt = new DataTable();

                adt.Fill(dt);

                dgvempsetting.DataSource = dt;

                con.Close();

                txtempqName.Text = "";
            }
        }

        private void emptypesave_Click(object sender, EventArgs e)
        {
            if (txtemptyename.Text == "")
            {
                pnlemptype.Show();
            }

            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeType(TypeID,Name,AddedDate,TDelID)VALUES('" + lblemptypeid.Text + "','" + txtemptyename.Text + "','" + dtpemptype.Text + "','" + emptypede + "')", con);

                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("INSERTED");

                empTypeID();

                emptypedel();


                con.Open();

                SqlDataAdapter adt = new SqlDataAdapter("SELECT * from EmployeeType", con);
                DataTable dt = new DataTable();

                adt.Fill(dt);

                dgvemptype.DataSource = dt;

                con.Close();

                txtemptyename.Text = "";

            }
        }

        private void txtempqName_Leave(object sender, EventArgs e)
        {
            if (txtempqName.Text == "")
            {
                pnlempqvali.Show();
            }
        }

        private void txtempqName_MouseClick(object sender, MouseEventArgs e)
        {
            pnlempqvali.Hide();
        }

        private void txtemptyename_Leave(object sender, EventArgs e)
        {
            if (txtemptyename.Text == "")
            {
                pnlemptype.Show();
            }
        }

        private void txtemptyename_MouseClick(object sender, MouseEventArgs e)
        {
            pnlemptype.Hide();
        }

        private void dgvempsetting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        int deleteID;

        private void dgvempsetting_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                deleteID = Convert.ToInt32(dgvempsetting.Rows[e.RowIndex].Cells["DelID"].Value.ToString());
                this.cmsdelete.Show(this.dgvempsetting, e.Location);
                cmsdelete.Show(Cursor.Position);

            }
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from EmployeeQualification where DelID= '" + deleteID + "'", con);
            con.Open();


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Completed");

            con.Open();

            SqlDataAdapter adt = new SqlDataAdapter("SELECT * from EmployeeQualification", con);
            DataTable dt = new DataTable();

            adt.Fill(dt);

            dgvempsetting.DataSource = dt;

            con.Close();

            empqid();
            empdel();
        }

        int emptypedelID;
        private void dgvemptype_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                emptypedelID = Convert.ToInt32(dgvemptype.Rows[e.RowIndex].Cells["TDelID"].Value.ToString());
                this.cmsemptype.Show(this.dgvemptype, e.Location);
                cmsemptype.Show(Cursor.Position);

            }
        }

        string para = "E:\\New folder\\day14\\New folder\\software\\Resources\\facebook-silhouette.jpg";
        string para2 = "./";

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from EmployeeType where TDelID= '" + emptypedelID + "'", con);
            con.Open();


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Completed");

            con.Open();

            SqlDataAdapter adt = new SqlDataAdapter("SELECT * from EmployeeType", con);
            DataTable dt = new DataTable();

            adt.Fill(dt);

            dgvemptype.DataSource = dt;

            con.Close();

            empTypeID();

            emptypedel();
        }

        private void btninsertemp_Click(object sender, EventArgs e)
        {
            new camera().Show();
        }
        string facere="faceRegistation";
        private void button7_Click(object sender, EventArgs e)
        {
            FrmPrincipal f = new FrmPrincipal(facere);
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new EmpSearch().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new EmpLeft().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new emphistory().Show();
        }
        string paymentNot;
        string discharge;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            txtcpayment.Text = "";
            pnlPayment.Show();
            paymentNot = "PAYMENT";
            discharge = dtpdischargeDate.Text;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pnlPayment.Hide();
            clienttotal = "0";
            txtcpayment.Text = "0";
            paymentNot = "NO_PAYMENT";
            discharge = "Null";
           
        }

        private void cmbtotal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        string imagelocation3="1";

        string clientId = System.Guid.NewGuid().ToString().Replace("-", "c");

        string Jdate = DateTime.Today.ToString("yyyy/MM/dd");


        string clienttotal;
        private void btnempreg_Click(object sender, EventArgs e)
        {
            if (txtclientName.Text == "" || txtcnic.Text == "" || txtcaddrees.Text == "" || txtcphone.Text == "" || rdoMale.Checked == false && rdoFemale.Checked == false || cmbcdrug.Text == "" || cmbccounciller.Text == "" || txtcjob.Text == "" || txtcguardian.Text == "" || rdopayment.Checked == false && rdonunpayment.Checked == false)
            {
                MessageBox.Show("Please check the form again");

                if (txtclientName.Text == "")
                {
                    pnlfullname.Show();
                }
                if (txtcnic.Text == "")
                {
                    pnlcNic.Show();

                }
                if (txtcaddrees.Text == "")
                {
                    pnlcaddress.Show();
                }
                if (txtcphone.Text == "")
                {
                    pnlcPhone.Show();
                }
                if (rdoMale.Checked == false && rdoFemale.Checked == false)
                {
                    pnlcGender.Show();
                }
                if (cmbcdrug.Text == "")
                {
                    pnlcDrug.Show();
                }
                if (cmbccounciller.Text == "")
                {
                    pnlccounciller.Show();

                }
                if (txtcjob.Text == "")
                {
                    pnlcJob.Show();
                }
                if (txtcguardian.Text == "")
                {

                    pnlcGuardian.Show();
                }
                if (rdopayment.Checked == false && rdonunpayment.Checked == false)
                {
                    pnlrdopaymentorNon.Show();
                }
            }
            else
            {


                if (rdopayment.Checked == true||rdonunpayment.Checked==true)
                {
                    if (rdopayment.Checked == true)
                    {
                         clienttotal = "15000";

                        if ( txtcpayment.Text == "")
                        {

                            MessageBox.Show("please check the form again");
                            
                                pnlcPay.Show();
                            

                        }
                        else
                        {

                            SqlDataAdapter adt = new SqlDataAdapter("select count(*) from ClientRegistation where NIC='" +txtcnic.Text + "'", con);
                            DataTable dt = new DataTable();
                            adt.Fill(dt);

                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                MessageBox.Show("Already complete the Registation");

                            }


                            else
                            {
                                byte[] im = null;

                                FileStream streem = new FileStream(imagelocation3, FileMode.Open, FileAccess.Read);
                                BinaryReader brs = new BinaryReader(streem);
                                im = brs.ReadBytes((int)streem.Length);


                                con.Open();

                                SqlCommand cmd = new SqlCommand("INSERT INTO ClientRegistation(ClientID,FullName,Address,NIC,PhoneNumber,Birthday,Gender,MainDrug,Counciller,Job,GuardianName,JoinDate,PaymentOrNot,Total,Payment,DischargeDate,ClientPhoto)VALUES('" + clientId + "','" + txtclientName.Text + "','" + txtcaddrees.Text + "','" + txtcnic.Text + "','" + txtcphone.Text + "','" + dtpcbirth.Text + "','" + Gender + "','" + cmbcdrug.Text + "','" + cmbccounciller.Text + "','" + txtcjob.Text + "','" + txtcguardian.Text + "','" + Jdate + "','" + paymentNot + "','" +  clienttotal + "','" + txtcpayment.Text + "','" + discharge + "',@im)", con);




                                cmd.Parameters.Add(new SqlParameter("@im", im));
                                cmd.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Save completed");

                                selectClient();

                                this.Close();

                                Home r = new Home(para, para2,typerec);

                                r.ShowDialog();
                            }








                        }
                    }
                    if (rdonunpayment.Checked == true)
                    {
                        clienttotal = "0";
                        SqlDataAdapter adt2 = new SqlDataAdapter("select count(*) from ClientRegistation where NIC='" + txtcnic.Text + "'", con);
                        DataTable dt2 = new DataTable();
                        adt2.Fill(dt2);

                        if (dt2.Rows[0][0].ToString() == "1")
                        {
                            MessageBox.Show("Already complete the Registation");

                        }

                        else
                        {

                            byte[] img = null;

                            FileStream streem = new FileStream(imagelocation3, FileMode.Open, FileAccess.Read);
                            BinaryReader brs = new BinaryReader(streem);
                            img = brs.ReadBytes((int)streem.Length);


                            con.Open();

                            SqlCommand cmd = new SqlCommand("INSERT INTO ClientRegistation(ClientID,FullName,Address,NIC,PhoneNumber,Birthday,Gender,MainDrug,Counciller,Job,GuardianName,JoinDate,PaymentOrNot,Total,Payment,DischargeDate,ClientPhoto)VALUES('" + clientId + "','" + txtclientName.Text + "','" + txtcaddrees.Text + "','" + txtcnic.Text + "','" + txtcphone.Text + "','" + dtpcbirth.Text + "','" + Gender + "','" + cmbcdrug.Text + "','" + cmbccounciller.Text + "','" + txtcjob.Text + "','" + txtcguardian.Text + "','" + Jdate + "','" + paymentNot + "','" + clienttotal + "','" + txtcpayment.Text + "','" + discharge + "',@img)", con);




                            cmd.Parameters.Add(new SqlParameter("@img", img));
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Save completed");

                            selectClient();

                            this.Close();

                            Home r = new Home(para, para2,typerec);

                            r.ShowDialog();

                        }










                    }


                }
                
                
                


            }
        }

        private void txtclientName_Click(object sender, EventArgs e)
        {
            pnlfullname.Hide();
        }

        private void txtclientName_Leave(object sender, EventArgs e)
        {
            if (txtclientName.Text == "")
            {
                pnlfullname.Show();
            }
        }

        private void txtcaddrees_Leave(object sender, EventArgs e)
        {
            if (txtcaddrees.Text == "")
            {
                pnlcaddress.Show();
            }
        }

        private void txtcaddrees_Click(object sender, EventArgs e)
        {
            pnlcaddress.Hide();
        }

        private void txtcnic_Leave(object sender, EventArgs e)
        {
            if (txtcnic.Text == "")
            {
                pnlcNic.Show();
            }
        }

        private void txtcnic_Click(object sender, EventArgs e)
        {
            pnlcNic.Hide();
        }

        private void rdoMale_Click(object sender, EventArgs e)
        {
            pnlcGender.Hide();
        }

        private void rdoFemale_Click(object sender, EventArgs e)
        {
            pnlcGender.Hide();
        }

        private void txtcjob_Click(object sender, EventArgs e)
        {
            pnlcJob.Hide();
        }

        private void txtcjob_Leave(object sender, EventArgs e)
        {
            if (txtcjob.Text == "")
            {
                pnlcJob.Show();
            }
        }

        private void txtcguardian_Leave(object sender, EventArgs e)
        {
            if (txtcguardian.Text == "")
            {
                pnlcGuardian.Show();
            }
        }

        private void txtcguardian_Click(object sender, EventArgs e)
        {
            pnlcGuardian.Hide();
        }

        private void rdopayment_Click(object sender, EventArgs e)
        {
            pnlrdopaymentorNon.Hide();
        }

        private void rdonunpayment_Click(object sender, EventArgs e)
        {
            pnlrdopaymentorNon.Hide();
        }

        private void txtctotal_Click(object sender, EventArgs e)
        {
            
        }

        private void txtctotal_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtcpayment_TextChanged(object sender, EventArgs e)
        {
            pnlcPay.Hide();
        }

        private void txtcpayment_Leave(object sender, EventArgs e)
        {
            if (txtcpayment.Text == "")
            {
                pnlcPay.Show();
            }
        }
        
        private void button11_Click(object sender, EventArgs e)
        {



            this.Close();

            Clientcamara c = new Clientcamara(typerec);
            c.ShowDialog();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            
           
            
        }

        string Gender;

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "MALE";
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "FEMAIL";
        }

        string clientID2;


        private void dgvclient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btncupdate.Enabled = true;
            btncdelete.Enabled = true;



            txtclientName.Enabled = true;
            txtcaddrees.Enabled = true;
            txtcnic.Enabled = true;
            txtcphone.Enabled = true;
            dtpcbirth.Enabled = true;
            cmbcdrug.Enabled = true;
            cmbccounciller.Enabled = true;
            txtcjob.Enabled = true;
            txtcguardian.Enabled = true;
            groupBox11.Enabled = true;

            try
            {
                SqlCommand cmd = new SqlCommand("select * from ClientRegistation", con);

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                clientID2 = table.Rows[e.RowIndex][0].ToString();

                byte[] img2 = (byte[])table.Rows[e.RowIndex][17];
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
                    dtpdischargeDate.Text = table.Rows[e.RowIndex][16].ToString();
                }
                if (paymentNot == "NO_PAYMENT")
                {
                    rdonunpayment.Checked = true;
                }
                
                txtcpayment.Text = table.Rows[e.RowIndex][15].ToString();
            
               


                MemoryStream ms = new MemoryStream(img2);
                pictureBox5.Image = Image.FromStream(ms);
                da.Dispose();
            }
            catch (Exception et)

            {
                MessageBox.Show("Please select correct data row that the datas are added");
           }



        }

        private void btncupdate_Click(object sender, EventArgs e)
        {
            clienttotal = "15000";
            string message = "Are you sure ";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {


                SqlCommand cmd = new SqlCommand("update ClientRegistation set FullName='" + txtclientName.Text + "',Address='" + txtcaddrees.Text + "',NIC='" + txtcnic.Text + "',PhoneNumber='" + txtcphone.Text + "',Birthday='" +dtpcbirth.Text + "',Gender='" + Gender + "',MainDrug='" + cmbcdrug.Text + "',Counciller='" + cmbccounciller.Text + "',Job='" + txtcjob.Text + "',GuardianName='" + txtcguardian.Text + "',JoinDate='"+Jdate+"',PaymentOrNot='"+paymentNot+"',Total='"+clienttotal+"',Payment='"+txtcpayment.Text+"',DischargeDate='"+dtpdischargeDate.Text+"' where ClientID='" +clientID2 + "'", con);
                SqlDataReader datare;

                con.Open();

                datare = cmd.ExecuteReader();
                MessageBox.Show("Updated");

                con.Close();

                selectClient();


                txtclientName.Enabled = false;
                txtcaddrees.Enabled = false;
                txtcnic.Enabled = false;
                txtcphone.Enabled = false;
                dtpcbirth.Enabled = false;
                cmbcdrug.Enabled = false;
                cmbccounciller.Enabled = false;
                txtcjob.Enabled = false;
                txtcguardian.Enabled = false;
                groupBox11.Enabled = false;
               
            }

        }

        private void btncdelete_Click(object sender, EventArgs e)
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


                    SqlCommand cmd = new SqlCommand("delete from ClientRegistation where ClientID ='" + clientID2 + "' ", con);
                    SqlDataReader datare;

                    con.Open();

                    datare = cmd.ExecuteReader();
                    MessageBox.Show("Deleted");

                    con.Close();

                    selectClient();


                    txtclientName.Enabled = false;
                    txtcaddrees.Enabled = false;
                    txtcnic.Enabled = false;
                    txtcphone.Enabled = false;
                    dtpcbirth.Enabled = false;
                    cmbcdrug.Enabled = false;
                    cmbccounciller.Enabled = false;
                    txtcjob.Enabled = false;
                    txtcguardian.Enabled = false;
                    groupBox11.Enabled = false;
                }


            }
            catch (Exception et)
            {
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string by = "clientFaceregister";
            FrmPrincipal t = new FrmPrincipal(by);
            t.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new clientHistory().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bg = "clientFaceregister1";

            FrmPrincipal v = new FrmPrincipal(bg);
            v.ShowDialog();
        }
        string coun;
        private void ggvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ClientRegistation", con);

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                


                byte[] img = (byte[])table.Rows[e.RowIndex][17];
                lblclientName.Text = table.Rows[e.RowIndex][2].ToString();
                lblclientNIC.Text = table.Rows[e.RowIndex][4].ToString();
                coun = table.Rows[e.RowIndex][9].ToString();
                lblclientGender.Text = table.Rows[e.RowIndex][7].ToString();

                MemoryStream ms = new MemoryStream(img);
                pictureBoxclientPhoto.Image = Image.FromStream(ms);
                da.Dispose();


                


                string empde = "Name:" + lblclientName.Text + ", NIC NUMBER:" + lblclientNIC.Text;


                QRCodeEncoder encoder = new QRCodeEncoder();
                Bitmap qrcode = encoder.Encode(empde);
                pictureBoxclientqr.Image = qrcode as Image;


                con.Close();
                con.Open();

                SqlCommand cmd2 = new SqlCommand("select * from EmployeeRegistation where EmpName='" + coun + "' ", con);

                DataTable table2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(table2);
                con.Close();



                byte[] img2 = (byte[])table2.Rows[0][11];
                lblcouncillerfullname.Text = table2.Rows[0][2].ToString();
                lblcouncillerNIC.Text = table2.Rows[0][3].ToString();
                lblcounsillerEmptype.Text = table2.Rows[0][7].ToString();
                lblcouncillerGender.Text = table2.Rows[0][9].ToString();



                MemoryStream ms2 = new MemoryStream(img2);
                pictureBoxcounciller.Image = Image.FromStream(ms2);
                da2.Dispose();


                string empde2 = "Name:" + lblcouncillerfullname.Text + ", NIC NUMBER:" + lblcouncillerNIC.Text;


                QRCodeEncoder encoder2 = new QRCodeEncoder();
                Bitmap qrcode2 = encoder.Encode(empde2);
                pictureBoxcouncillerqr.Image = qrcode as Image;

            }
            catch (Exception ert)
            {
                MessageBox.Show("Please select correct data row that the datas are added");
            }


        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlClientSetting.Show();
            pnlclient.Show();
            pnlemp.Show();
            pnlempsetting.Show();
            pnlHome.Hide();
        }

        private void dgvclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCsName_Leave(object sender, EventArgs e)
        {
            if (txtCsName.Text == "")
            {
                pnlCsName.Show();
            }
            else
            {
                pnlCsName.Hide();
            }
        }

        private void txtCsName_Click(object sender, EventArgs e)
        {
            pnlCsName.Hide();
        }

        private void btnaddDrug_Click(object sender, EventArgs e)
        {
            if (txtCsName.Text == "")
            {
                pnlCsName.Show();

                MessageBox.Show("Please check the form again");

            }
            else
            {
                SqlDataAdapter adt2 = new SqlDataAdapter("select count(*) from DrugType where Name='" + txtCsName.Text + "'", con);
                DataTable dt2 = new DataTable();
                adt2.Fill(dt2);

                if (dt2.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already complete the Registation");

                }




                else
                {



                    string DrugID = System.Guid.NewGuid().ToString().Replace("-", "D");



                    SqlCommand cmd = new SqlCommand("INSERT INTO DrugType(DrugID,Name,AddedDate)VALUES('" + DrugID + "','" + txtCsName.Text + "','" + dtpCsAddedDate.Text + "')", con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("INSERTED");


                    con.Open();

                    SqlDataAdapter adt = new SqlDataAdapter("SELECT * from DrugType", con);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgvClientS.DataSource = dt;

                    con.Close();

                    txtCsName.Text = "";

                }

            }
        }
        string CsID;
        private void dgvClientS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from DrugType", con);

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);




            txtCsName.Text = table.Rows[e.RowIndex][1].ToString();
            dtpCsAddedDate.Text = table.Rows[e.RowIndex][2].ToString();
            CsID = table.Rows[e.RowIndex][0].ToString();

            con.Close();
            }
            catch(Exception ert)
            {
                MessageBox.Show("Please select correct data row that the datas are added");
            }
                
        }

        private void btnDelDrug_Click(object sender, EventArgs e)
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


                    SqlCommand cmd = new SqlCommand("delete from DrugType where DrugID ='" + CsID + "' ", con);
                    SqlDataReader datare;

                    con.Open();

                    datare = cmd.ExecuteReader();
                    MessageBox.Show("Deleted");

                    con.Close();


                    con.Open();

                    SqlDataAdapter adt = new SqlDataAdapter("SELECT * from DrugType", con);
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    dgvClientS.DataSource = dt;

                    con.Close();
                }


            }
            catch (Exception et)
            {
                MessageBox.Show("Error");
            }
        }

        string total;
        string payment;

        string clientid3;

        private void dgvclientshow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grppayment.Hide();

            string gen;
            string pay;
            try
            {
                SqlCommand cmd = new SqlCommand("select * from ClientRegistation", con);

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                total = table.Rows[e.RowIndex][14].ToString();
                payment = table.Rows[e.RowIndex][15].ToString();

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
                else if(gen=="FEMALE")
                {
                    rdohomefemale.Checked=true;
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

        private void btnhomepaymentdis_Click(object sender, EventArgs e)
        {
            
            string date=DateTime.Today.ToString("yyyy/MM/dd");
            
            if (Convert.ToInt32(total) > Convert.ToInt32(payment))
            {
                grppayment.Show();
                lblHometotal.Text = total;
                lblhomeadvance.Text = payment;
                int tot = Convert.ToInt32(total);
                int pay = Convert.ToInt32(payment);

                int amount = tot - pay;

                lblhomeinstalment.Text = amount.ToString();

            }

            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ClientHistory(ClientID,FullName,Address,NIC,PhoneNumber,Birthday,Gender,MainDrug,Job,GuardianName,PaymentOrNot,DischargeDate)VALUES('" +clientid3 + "','" +txthomecname.Text + "','" + txthomeaddress.Text + "','" + txthomeNIC.Text + "','"+txthomephone.Text+"','"+dtphomecbirthday.Text+"','"+gender2+"','"+cmbhomedrug.Text+"','"+txthomejob.Text+"','"+txthomeguardian.Text+"','"+paytype+"','"+date+"')", con);

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date1 = DateTime.Today.ToString("yyyy/MM/dd");


            if (txtinstalment.Text == lblhomeinstalment.Text)
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO ClientHistory(ClientID,FullName,Address,NIC,PhoneNumber,Birthday,Gender,MainDrug,Job,GuardianName,PaymentOrNot,DischargeDate)VALUES('" + clientid3 + "','" + txthomecname.Text + "','" + txthomeaddress.Text + "','" + txthomeNIC.Text + "','" + txthomephone.Text + "','" + dtphomecbirthday.Text + "','" + gender2 + "','" + cmbhomedrug.Text + "','" + txthomejob.Text + "','" + txthomeguardian.Text + "','" + paytype + "','" + date1 + "')", con);

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
            else
            {
                MessageBox.Show("please set the instalment");

            }
        }
        string gender2;
        private void rdohomemale_CheckedChanged(object sender, EventArgs e)
        {
            gender2 = "MALE";
        }

        private void rdohomefemale_CheckedChanged(object sender, EventArgs e)
        {
            gender2 = "FEMALI";

        }

        string paytype;
        private void rdohomepayment_CheckedChanged(object sender, EventArgs e)
        {
            paytype = "PAYMENT";
        }

        private void rdohomenunpayment_CheckedChanged(object sender, EventArgs e)
        {
            paytype = "NO_payment";
        }

        private void btnhomenondis_Click(object sender, EventArgs e)
        {
            new permenetClient().Show();
        }
    }
}
