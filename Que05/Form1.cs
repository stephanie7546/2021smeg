using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Que05
{
    public partial class Form1 : Form
    {
        System.Timers.Timer mytimer;

        public Form1()
        {
            InitializeComponent();

            Timer t = new Timer();
            t.Interval = 1000;

            string clock_to_year = DateTime.Now.Year.ToString();
            DateTime clock_end = DateTime.Parse(clock_to_year+ "/12/31 23:59:59");

            t.Tick += new EventHandler(t_Tick);
            TimeSpan ts = clock_end.Subtract(DateTime.Now);
            string clock1 = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            label1.Text = "現在時間：" + DateTime.Now.ToString() + "\n";
            label1.Text += "距離今年年底(" + clock_to_year + "-12-31)" + "還有" + clock1;
            t.Start();

        }

        private void t_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            string clock_to_year = DateTime.Now.Year.ToString();
            DateTime clock_end = DateTime.Parse(clock_to_year + "/12/31 23:59:59");
            TimeSpan ts = clock_end.Subtract(DateTime.Now);
            string clock1 = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            label1.Text = "現在時間：" + DateTime.Now.ToString() + "\n";
            label1.Text += "距離今年年底(" + clock_to_year + "-12-31)" + "還有" + clock1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
