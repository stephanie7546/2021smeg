using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Que02
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calendar1_SelectionChanged(object sender, EventArgs e)
        {
            string choice_date = null;
            choice_date = calendar1.SelectedDate.ToString("yyyy/MM/dd");
            if(choice_date.Substring(5,5) == "05/20")
            {
                Label1.Text = "您選擇的日期為" + choice_date + "為總統就職日！！！";
            }
            else
            {
                Label1.Text = "";
            }
            
        }
    }
}