using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_2
{
    public partial class ElectionForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var data = "Registered Sucessfully";
            Response.Write(data);
           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (RadioButtonList1.SelectedValue != null)
            {
               Response.Write("Selected House is : " + RadioButtonList1.Text  + "<br/>");
            }
        }
    }
}