
//Multiple face detection and recognition in real time
//Using EmguCV cross platform .Net wrapper to the Intel OpenCV image processing library for C#.Net
//Writed by Sergio Andrés Guitérrez Rojas
//"Serg3ant" for the delveloper comunity
// Sergiogut1805@hotmail.com
//Regards from Bucaramanga-Colombia ;)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;


namespace MultiFaceRec
{
    public partial class FrmPrincipal : Form
    {
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels= new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;

        string bh;
        public FrmPrincipal(string facedec)
        {
            InitializeComponent();

            bh = facedec;
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels+1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
            
            }
        

                
               

            catch(Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            empnamecombo();

        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\my project\drugs control board\day14\Dcsd-ka-171\New folder\database\drugsControlBoard.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        void empnamecombo()
        {

            

            con.Open();
            SqlCommand cmd = new SqlCommand("select EmpName from EmployeeRegistation", con);
            cmd.ExecuteNonQuery();
           

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

               textBox1.Items.Add(dr["EmpName"].ToString());
            }


            con.Close();


        }

        void clientnamecombo()
        {




            con.Open();
            SqlCommand cmd = new SqlCommand("select FullName from ClientRegistation", con);
            cmd.ExecuteNonQuery();


            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

               textBox1.Items.Add(dr["FullName"].ToString());
            }


            con.Close();


        }

       



        private void button1_Click(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;
        }


        private void button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(textBox1.Text);

                //Show face added in gray scale
                imageBox1.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                //MessageBox.Show(textBox1.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        string ne;
        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");



            try
            {
                currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            }
            catch (Exception)
            {
                this.Close();
            }
            
          
                    //Convert it to Grayscale
                    gray = currentFrame.Convert<Gray, Byte>();

                    //Face Detector
                    MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                  face,
                  1.2,
                  10,
                  Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                  new Size(20, 20));

                    //Action for each element detected
                    foreach (MCvAvgComp f in facesDetected[0])
                    {
                        t = t + 1;
                        result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        //draw the face detected in the 0th (gray) channel with blue color
                        currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                        if (trainingImages.ToArray().Length != 0)
                        {
                            //TermCriteria for face recognition with numbers of trained images like maxIteration
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                        //Eigen face recognizer
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                           trainingImages.ToArray(),
                           labels.ToArray(),
                           3000,
                           ref termCrit);

                        name = recognizer.Recognize(result);

                            //Draw the label for each face detected and recognized
                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                        }

                            NamePersons[t-1] = name;
                            NamePersons.Add("");


                        //Set the number of faces detected on the scene
                        label3.Text = facesDetected[0].Length.ToString();
                       
                        
                        //Set the region of interest on the faces
                        
                        gray.ROI = f.rect;
                        MCvAvgComp[][] eyesDetected = gray.DetectHaarCascade(
                           eye,
                           1.1,
                           10,
                           Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                           new Size(20, 20));
                        gray.ROI = Rectangle.Empty;

                        foreach (MCvAvgComp ey in eyesDetected[0])
                        {
                            Rectangle eyeRect = ey.rect;
                            eyeRect.Offset(f.rect.X, f.rect.Y);
                            currentFrame.Draw(eyeRect, new Bgr(Color.Blue), 2);
                        }
                         

                    }


                        t = 0;

                        //Names concatenation of persons recognized
                        //for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
                  //{
                        //names = names + NamePersons[nnn] + ", ";
                   //}
                    //Show the faces procesed and recognized
                    imageBoxFrameGrabber.Image = currentFrame;
                    names = NamePersons[0];
                    label4.Text = names;
                    names = "";
                    //Clear the list(vector) of names
                    NamePersons.Clear();
                    

                     ne = label4.Text;
                    label6.Text = ne;

                    if (label6.Text == "")
                    {
                        attendence.Enabled = false;

                    }
                    else
                    {
                        attendence.Enabled = true;
                        //MessageBox.Show(label6.Text + "bhsadsad");
                    }

                    


                }

        //private void button3_Click(object sender, EventArgs e)
        //{
            //Process.Start("Donate.html");
        //}

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            attendence.Enabled = false;
            
            
            btncheckatten.Hide();
            btnaddattendence.Hide();
            label1.Show();

            clientnamecombo();

            if (bh == "faceRegistation")
            {
                attendence.Hide();
                label6.Hide();
            }
            else if (bh == "faceds")
            {
                attendence.Show();
                textBox1.Hide();
                label1.Hide();
                button2.Hide();
            }
            else if (bh == "clientFaceregister")
            {
                label1.Show();
               
                attendence.Hide();

                
                //btnaddattendence.Show();
                //btncheckatten.Show();

            }

            else if (bh == "clientFaceregister1")
            {
                label1.Hide();
                textBox1.Hide();
                
                attendence.Hide();
                button2.Hide();

                
                btnaddattendence.Show();
                btncheckatten.Show();

            }

           

          
        }
        string empidforsign;
        string type;
        private void attendence_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from EmployeeRegistation where EmpName='"+label6.Text+"'", con);

            SqlDataReader mdr;
            
            mdr = cmd.ExecuteReader();

            if (mdr.Read())
            {
                empidforsign = (mdr["EmpID"].ToString());

                type = (mdr["EmployeeType"].ToString());
            }
            else
            {
                MessageBox.Show("There is no data");
            }



            con.Close();
            
            SqlDataAdapter adt = new SqlDataAdapter("select count(*) from Login where EmpPID='" + empidforsign + "'", con);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            if (type == "maneger" || type == "counsiler" || type == "Data Entry")
            {
                MessageBox.Show("Recognition is Completed");

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already have a account");
                }
                else
                {

                    signUpemp r = new signUpemp(empidforsign);

                    r.ShowDialog();
                }
            }
            else
            {

                MessageBox.Show("Cannot create Account");
               
            }
            

            if (grabber != null)
            {
                grabber.Dispose();


            }
            
           



            
            

            
         }

        private void imageBoxFrameGrabber_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (grabber != null)
            {
                grabber.Dispose();
               
                
            }
            this.Close();
            
        }

        string ClientId;
        string totaydate = DateTime.Today.ToString("yyyy/MM/dd");
        string time = DateTime.Now.ToString("hh.mm.ss");

        string vr;
        private void btnaddattendence_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adt = new SqlDataAdapter("select count(*) from ClientAttendence where FullName='" + label6.Text + "'", con);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Already Have a attendence");

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from ClientRegistation where FullName='" + label6.Text + "'", con);

                SqlDataReader mdr;

                mdr = cmd.ExecuteReader();

                

                

                if (mdr.Read())
                {
                    
                    ClientId = (mdr["ClientID"].ToString());

                    vr = "vbHave";





                }
                else
                {
                    MessageBox.Show("There is no data");
                }
                con.Close();


                if (vr=="vbHave")
                {
                    con.Open();

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO ClientAttendence(ClientID,FullName,Date,Time)VALUES('" + ClientId + "','" + label6.Text + "','" + totaydate + "','" + time + "')", con);



                    cmd2.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Completed");
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Cannot find this person");
                }
                
            }


        }

        private void btncheckatten_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

    }
}