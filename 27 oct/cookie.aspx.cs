using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesASP
{
    public partial class CookiASP1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creating httpCookie instance by specifying the name "student"
            HttpCookie cookie = new HttpCookie("Student");

            cookie.Value = "Aishu";
            

            Response.Cookies.Add(cookie);
            

            var Cookie_Value = Response.Cookies["student"].Value;

            Label1.Text = Cookie_Value;

            HttpCookie cookie1 = new HttpCookie("Documents");

            cookie1.Value = "Forms";


            Response.Cookies.Add(cookie1);


            var Cookie_Value1 = Response.Cookies["Documents"].Value;

            Label2.Text = Cookie_Value1;


            //setting Expiry date and Time of the Cookie
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);




        }

       

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label4.Text = "Please Select your Choice";

            //Adding Cookies
            if (iphone.Checked)
                Response.Cookies["computer"]["iphone"] = "You have checked for iphone and Cookie Triggered";

            if (Oneplus.Checked)
                Response.Cookies["computer"]["Oneplus"] = "You have checked for Oneplus and Cookie Triggered";

            if (samsung.Checked)
                Response.Cookies["computer"]["samsung"] = "You have checked for samsung and Cookie Triggered";

            if (oppo.Checked)
                Response.Cookies["computer"]["oppo"] = "You have checked for oppo and Cookie Triggered";

            if (Nokia.Checked)
                Response.Cookies["computer"]["Nokia"] = "You have checked for nokia and Cookie Triggered";

            if (RealMe.Checked)
                Response.Cookies["computer"]["RealMe"] = "You have checked for RealMe and Cookie Triggered";

            if (Vivo.Checked)
                Response.Cookies["computer"]["Vivo"] = "You have checked for Vivo and Cookie Triggered";

            if (Lenovo.Checked)
                Response.Cookies["computer"]["Lenovo"] = "You have checked for Lenovo and Cookie Triggered";

            if (Lava.Checked)
                Response.Cookies["computer"]["Lava"] = "You have checked for Lava and Cookie Triggered";

            if (Micromax.Checked)
                Response.Cookies["computer"]["Micromax"] = "You have checked for MicroMax and Cookie Triggered";



            //fetching cookie
            if (Request.Cookies["computer"].Values.ToString()!=null)
            {
                if (Request.Cookies["computer"]["iphone"] != null)
                    Label4.Text = Label4.Text +Response.Cookies ["computer"]["iphone"] + " " + " ";
                if (Request.Cookies["computer"]["Oneplus"] != null)
                    Label4.Text = Label4.Text +Response.Cookies ["computer"]["Oneplus"] + " " + " ";
                if (Request.Cookies["computer"]["samsung"] != null)
                    Label4.Text = Label4.Text +Response.Cookies ["computer"]["samsung"] + " " + " ";
                if (Request.Cookies["computer"]["oppo"] != null)
                    Label4.Text = Label4.Text +Response.Cookies ["computer"]["oppo"] + " " + " ";
                if (Request.Cookies["computer"]["Nokia"] != null)
                    Label4.Text = Label4.Text +Response.Cookies ["computer"]["Nokia"] + " " + " ";

                if (Request.Cookies["computer"]["RealMe"] != null)
                    Label4.Text = Label4.Text + Response.Cookies["computer"]["RealMe"] + " " + " ";

                if (Request.Cookies["computer"]["Vivo"] != null)
                    Label4.Text = Label4.Text + Response.Cookies["computer"]["Vivo"] + " " + " ";

                if (Request.Cookies["computer"]["Lenovo"] != null)
                    Label4.Text = Label4.Text + Response.Cookies["computer"]["Lenovo"] + " " + " ";

                if (Request.Cookies["computer"]["Lava"] != null)
                    Label4.Text = Label4.Text + Response.Cookies["computer"]["Lava"] + " " + " ";

                if (Request.Cookies["computer"]["MicroMax"] != null)
                    Label4.Text = Label4.Text + Response.Cookies["computer"]["Micromax"] + " " + " ";
            }
            else
            {
                Label4.Text = "Please Select your Choice\n";
                Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}