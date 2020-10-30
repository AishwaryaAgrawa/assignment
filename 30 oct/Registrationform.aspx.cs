using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment1
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var data = "Registered Sucessfully";
            Response.Write(data);

           
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3.Checked)
            {

                if (CheckBox1.Checked)
                {
                    Response.Write("You have clicked Microcontroller" + "<br/>");
                }
                if (CheckBox2.Checked)
                {
                    Response.Write("You have clicked Electronics Devices & Circuits" + "<br/>");
                }
                if (CheckBox3.Checked)
                {
                    Response.Write("You have clicked Analog Communication" + "<br/>");
                }
            }
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            if(RadioButton4.Checked)
            {
                if (CheckBox4.Checked)
                {
                    Response.Write("You have clicked Data Structures" + "<br/>");
                }
                if (CheckBox5.Checked)
                {
                    Response.Write("You have clicked Java" + "<br/>");
                }
                if (CheckBox6.Checked)
                {
                    Response.Write("You have clicked Computer Networks" + "<br/>");
                }
            }

        }
    }
}