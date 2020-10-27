using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication4
{
    public partial class DataListExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            Table.Columns.Add("Fname");
            Table.Columns.Add("Lname");
            Table.Columns.Add("Designation");
            Table.Columns.Add("Location");
            Table.Columns.Add("Country");

            Table.Rows.Add(101, "Ram", "SE","Chennai","India");
            Table.Rows.Add(102, "kajal", "HR","Delhi","India");
            Table.Rows.Add(103, "sweta", "QA","Bangalor","India");
            Table.Rows.Add(104, "sunali", "SE","Channai","India");
            Table.Rows.Add(105, "sham", "JE", "Delhi", "India");
            Table.Rows.Add(106, "akash", "SE", "Delhi", "India");
            Table.Rows.Add(107, "Seema", "JE", "Channai", "India");
            Table.Rows.Add(108, "shiva", "HR", "Bangalor", "India");
            Table.Rows.Add(109, "Amit", "HR", "Delhi", "India");
            Table.Rows.Add(110, "sunil", "SE", "Channai", "India");


            

            datalist1.DataSource = Table;
            datalist1.DataBind();
        }
    }
}