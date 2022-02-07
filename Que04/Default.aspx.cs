using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Que04
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert1_Click(object sender, EventArgs e)
        {
            string insert_value = TextBox1.Text;
            DropDownList1.Items.Add(new ListItem(insert_value, insert_value));
            Label1.Text = "新增景點：" + insert_value;
        }

        protected void delete1_Click(object sender, EventArgs e)
        {
            string delete_value = DropDownList1.SelectedValue;
            DropDownList1.Items.Remove(delete_value);
            Label1.Text = "移除景點：" + delete_value;
        }

    }
}