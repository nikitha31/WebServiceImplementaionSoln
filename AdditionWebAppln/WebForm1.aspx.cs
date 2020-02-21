using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdditionWebAppln
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.AdditionServiceSoapClient obj = new ServiceReference2.AdditionServiceSoapClient();

            int result = obj.Add(Convert.ToInt32(TextBox1.Text), 
                Convert.ToInt32(TextBox2.Text));
            Label1.Text = result.ToString();

        }
    }
}