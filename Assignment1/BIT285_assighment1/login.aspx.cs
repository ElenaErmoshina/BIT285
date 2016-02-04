using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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
                Session["username"] = UserName.Text;
                LogCurrentUser(UserName.Text);
                Server.Transfer("Welcome.aspx");
            }
            else if (Password.Text == "")
            {
                Server.Transfer("NewAccount.aspx");
            }
            else
            {
                Session["username"] = UserName.Text;
                LogCurrentUser(UserName.Text);
                Server.Transfer("Welcome.aspx");
                // LoginError.Visible = true;
            }
        }

        private void LogCurrentUser(string username)
        {
            var log = (DataTable)Application["visitorTable"];
            var row = log.NewRow();

            row["session_id"] = Guid.NewGuid().ToString();
            row["username"] = username;
            row["login_time"] = DateTime.Now;
            row["ip_address"] = Request.UserHostAddress;

            log.Rows.Add(row);
        }
    }
}