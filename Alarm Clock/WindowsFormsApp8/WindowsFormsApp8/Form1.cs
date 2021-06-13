using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour, min, sec;
        string alrmHour, alrmMin;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = DateTime.Now.Second;
            min = DateTime.Now.Minute;
            hour = DateTime.Now.Hour;
            label2.Text = hour.ToString();
            label3.Text = min.ToString();
            label4.Text = sec.ToString();
            Ring_Alarm();
         
        }
        void Ring_Alarm()
        {
            if (alrmHour == hour.ToString() && alrmMin == min.ToString() && sec.ToString() == "0")
            {
                axWindowsMediaPlayer1.URL = @"D:\uni work\5th semester\VPL\vpl Assignments\Alarm Clock\WindowsFormsApp8\WindowsFormsApp8\Resources\Wecker-sound.mp3";
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alrmHour = comboBox1.Text;
            alrmMin = comboBox2.Text;
            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Alarm Has  Not Been Set Successfuly");
            }
            else
            {
                MessageBox.Show("Alarm Has Been Set Successfuly");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
