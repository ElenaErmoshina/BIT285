using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using System.Data;

namespace BIT285_assighment1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            string JQueryVer = "2.2.0";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-" + JQueryVer + ".min.js",
                DebugPath = "~/Scripts/jquery-" + JQueryVer + ".js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery"
            });

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("session_id",
            System.Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("username",
            System.Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("login_time",
            System.Type.GetType("System.DateTime")));
            dt.Columns.Add(new DataColumn("ip_address",
            System.Type.GetType("System.String")));


            // store the DataTable as an Application variable
            Application["visitorTable"] = dt;
        }
    }
}