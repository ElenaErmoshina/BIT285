using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIT285_assighment1
{
    public partial class NewAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //It checks if email box is checked and the email field is not empty.
        protected void EmailValidator_ServerValidate1(object source, ServerValidateEventArgs args)
        {
            if (this.CheckBox1.Checked && string.IsNullOrEmpty(args.Value))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        //Each item of data is collected to Session
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["firstName"] = txtFirstName.Text;
                Session["lastName"] = txtLastName.Text;
                Session["Email"] = txtEmail.Text;
                Session["ProgramOption"] = txtProgramOption.Text;
                Server.Transfer("CreatePassword.aspx", true);
            }
        }
    }
}