using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;




namespace MultiFaceRec
{
    public partial class camera : Form
    {
        
        public camera()
        {
            InitializeComponent();

            
        }
        private FilterInfoCollection captureDevices;
        private VideoCaptureDevice videoSource;

       





        private void panel6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void camera_Load(object sender, EventArgs e)
        {
            captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach(FilterInfo Device in captureDevices )
            {

                comboBox1.Items.Add(Device.Name);

            }
            comboBox1.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(captureDevices[comboBox1.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
        }

        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            pictureBox2.Image = null;
            pictureBox2.Invalidate();
        }

        private void btncap_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.* ";
            string newguid = "p" + DateTime.Now.ToString("hhmmss");



            

            pictureBox2.Image.Save("E:\\New folder\\day10\\New folder\\employee photos\\"+newguid+".png");

            string path = "E:\\New folder\\day10\\New folder\\employee photos\\" + newguid + ".png";
           

            MessageBox.Show(" save completed");


            if (pictureBox2.Image != null)
            {

                registationEmp r = new registationEmp(path);

                r.ShowDialog();

                if (videoSource.IsRunning == true)
                {

                    videoSource.Stop();
                }
                this.Close();

               

            }
            else
            {
                label2.Text = "First take a Photo";
            }
                




            

        }

        private void panel6_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
