using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiClock_Takbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            this.Height = 32;

            Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - this.Height);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, inTimeZone);
            label3.Text = inTime.ToString("hh:mm tt");

             inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time (Mexico)");
             inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, inTimeZone);
            label4.Text = inTime.ToString("hh:mm tt");

            inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SA Pacific Standard Time");
            inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, inTimeZone);
            label5.Text = inTime.ToString("hh:mm tt");


            inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GTB Standard Time");
            inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, inTimeZone);
            label6.Text = inTime.ToString("hh:mm tt");


        }
    }
}
