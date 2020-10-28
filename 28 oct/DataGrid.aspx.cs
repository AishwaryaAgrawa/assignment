using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class DataGrid_Prac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=IN-5CG03284JT\\SQLEXPRESS;Database=Dxc; integrated security=true"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Employee1", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                datagrid1.DataSource = ds;
                datagrid1.DataBind();

                SqlDataAdapter sda1 = new SqlDataAdapter("select * from Student", con);
                DataSet ds1 = new DataSet();
                sda.Fill(ds1);
                datagrid2.DataSource = ds1;
                datagrid2.DataBind();

                SqlDataAdapter sda2 = new SqlDataAdapter("select * from Indian_Cricket_Team", con);
                DataSet ds2 = new DataSet();
                sda.Fill(ds2);
                datagrid3.DataSource = ds2;
                datagrid3.DataBind();

                SqlDataAdapter sda3 = new SqlDataAdapter("select * from Indian_Railway_System", con);
                DataSet ds3 = new DataSet();
                sda.Fill(ds3);
                datagrid4.DataSource = ds3;
                datagrid4.DataBind();

                SqlDataAdapter sda4 = new SqlDataAdapter("select * from Bank_Table", con);
                DataSet ds4 = new DataSet();
                sda.Fill(ds4);
                datagrid5.DataSource = ds4;
                datagrid5.DataBind();
            }
        
        }
    }
}