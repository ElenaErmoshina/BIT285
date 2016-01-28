using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIT285_assighment1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "Ian" && Password.Text == "password")
            {
                Server.Transfer("Welcome.aspx");
            }
            else if (Password.Text == "")
            {
                Server.Transfer("Default.aspx");
            }
            else
            {
                LoginError.Visible = true;
            }
        }
    }
}