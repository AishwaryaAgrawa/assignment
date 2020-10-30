using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication5
{
    public partial class Registraion_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Registration values(@uname,@email,@pwd,@gender,@city)", con);
            cmd.Parameters.AddWithValue("@uname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@pwd", TextBox3.Text);
            if(RadioButton1.Checked)
            {
                cmd.Parameters.AddWithValue("@gender", RadioButton1.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@gender", RadioButton2.Text);
            }
            cmd.Parameters.AddWithValue("@city", DropDownList1.SelectedItem.Text);
            int affrow = cmd.ExecuteNonQuery();
            if(affrow>0)
            {
                Response.Redirect("Admin_Page.aspx");
            }
            
        }
    }
}