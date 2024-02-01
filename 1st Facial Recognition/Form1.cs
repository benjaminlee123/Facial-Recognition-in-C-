using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1st_Facial_Recognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to NYP Facial Recognition System ");
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentRecord add = new AddStudentRecord();
            add.Show();
            this.Hide();

        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            FaceDetection add = new FaceDetection();
            add.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.txtShowDateTime.Text = dateTime.ToString();
        }

        private void txtShowDateTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}