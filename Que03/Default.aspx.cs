using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Que03
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            string num = dateTime1.Hour.ToString();
            int hour_num = Int32.Parse(num);
            string ampm = "";

            if(hour_num < 12)
            {
                ampm = "上午 ";
            }
            else
            {
                ampm = "下午 ";
            }

            if (hour_num > 22)
            {
                Label1.Text = "現在時間為" + ampm + dateTime1.ToString("HH:mm:ss");
            }
            else
            {
                Label1.Text = num;
            }

        }
    }
}