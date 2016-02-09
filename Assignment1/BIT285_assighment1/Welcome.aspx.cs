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

        //It makes the label loged out invisible / visible.
        //It refreshes table after the button is clicked.
        protected void Refresh_Click(object sender, EventArgs e)
        {
            loggedOutLabel.Visible = false;
            GridDataBind();
        }

        //It says that the grid will get the data from visitor table.
        private void GridDataBind()
        {
            UserLogGrid.DataSource = (DataTable)Application["visitorTable"];
            UserLogGrid.DataBind();
        }

        //Logged out cleans the session and removes the user form the list.
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