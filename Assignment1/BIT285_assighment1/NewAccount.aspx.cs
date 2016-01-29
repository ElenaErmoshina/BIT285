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

        protected void EmailValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Console.WriteLine("");
        }

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("CreatePassword.aspx", true);
        }
    }
}