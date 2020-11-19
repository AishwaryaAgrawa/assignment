using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemanagement
{
    public partial class stateManagement : System.Web.UI.Page
    {
      int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HiddenField2.Value == String.Empty)
                HiddenField2.Value = "3";
            HiddenField2.Value = (Convert.ToInt32(HiddenField2.Value) + 1).ToString();
            Label1.Text = HiddenField2.Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count =int.Parse(HiddenField1.Value);
            count += 1;
            Response.Write("Number of hits are " +count );
            HiddenField1.Value = count.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            hdnfldCurrentDateTime.Value = DateTime.Now.ToString();
            lbl.Text = Convert.ToString(hdnfldCurrentDateTime.Value);
        }

      

        protected void Button3_Click(object sender, EventArgs e)
        {
            HiddenField3.Value = "Prathyusha";
            Label2.Text = HiddenField3.Value;
        }
    }
}