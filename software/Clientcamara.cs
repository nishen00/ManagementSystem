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
    public partial class Clientcamara : Form
    {
        int type34;
        public Clientcamara(int type)
        {
            InitializeComponent();
            type34 = type;
        }
        private FilterInfoCollection captureDevices;
        private VideoCaptureDevice videoSource;


        private void camera_Load(object sender, EventArgs e)
        {
            captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo Device in captureDevices)
            {

                comboBox1.Items.Add(Device.Name);

            }
            comboBox1.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clientcamara_Load(object sender, EventArgs e)
        {
            captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo Device in captureDevices)
            {

                comboBox1.Items.Add(Device.Name);

            }
            comboBox1.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(captureDevices[comboBox1.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
        }

        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            pictureBox2.Image = null;
            pictureBox2.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }
        string type = "done";
        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.* ";
            string newguid = "p" + DateTime.Now.ToString("hhmmss");





            pictureBox2.Image.Save("E:\\New folder\\day14\\New folder\\client photos\\" + newguid + ".png");

            string path = "E:\\New folder\\day14\\New folder\\client photos\\" + newguid + ".png";


            MessageBox.Show(" save completed");


            if (pictureBox2.Image != null)
            {

                if (videoSource.IsRunning == true)
                {

                    videoSource.Stop();
                    this.Close();
                }

                this.Close();


                

                Home r = new Home(path,type,type34);
                
                r.ShowDialog();
                
                

                


                



            }
            else
            {
                label2.Text = "First take a Photo";
            }
                
        }
    }
}
