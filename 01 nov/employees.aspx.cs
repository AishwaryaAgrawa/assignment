using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataboundControls
{
    public partial class employees : System.Web.UI.Page
    {
        SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeTableConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Bind();
            }

        }

        public void Bind()
        {
            Connect.Open();

            SqlCommand cmd = new SqlCommand("select * from Employee", Connect);
            SqlDataAdapter Adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            Adapt.Fill(ds, "Employee");
            rp2.DataSource = ds.Tables[0];
            rp2.DataBind();
            Connect.Close();

        }



    }
}