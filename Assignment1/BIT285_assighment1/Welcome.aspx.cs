using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BIT285_assighment1
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridDataBind();
        }

        protected void Refresh_Click(object sender, EventArgs e)
        {
            loggedOutLabel.Visible = false;
            GridDataBind();
        }

        private void GridDataBind()
        {
            UserLogGrid.DataSource = (DataTable)Application["visitorTable"];
            UserLogGrid.DataBind();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            loggedOutLabel.Visible = true;
            var log = (DataTable)Application["visitorTable"];
            foreach (DataRow row in log.Rows)
            {
                if ((string)row["username"] == (string)Session["username"])
                {
                    log.Rows.Remove(row);
                    break;
                }
            }

            Application["visitorTable"] = log;
            GridDataBind();
        }
    }
}