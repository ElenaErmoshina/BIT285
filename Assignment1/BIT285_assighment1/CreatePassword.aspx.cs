using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIT285_assighment1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                TextBox SourceTextBox =
                    (TextBox)PreviousPage.FindControl("txtLastName");
                if (SourceTextBox != null)
                {
                    txtLastName.Text = SourceTextBox.Text;
                }
            }
        }
        
        protected void SuggestBtn_Click(object sender, EventArgs e)
        {
            this.SuggestionDdl.Items.Clear();
            this.SuggestionDdl.Items.Add(this.txtLastName.Text +
                this.FavouriteColor.Text + this.BirthYear.Text);
            this.SuggestionDdl.Items.Add(this.FavouriteColor.Text + this.FavouriteColor.Text +
                this.BirthYear.Text);
            this.SuggestionDdl.Items.Add(this.BirthYear.Text + this.txtLastName.Text +
                this.txtLastName.Text);
            this.SuggestionDdl.Items.Add(this.txtLastName.Text.Substring(0, 3) +
                this.BirthYear.Text.Substring(2, 2) + this.FavouriteColor.Text);
            this.SuggestionDdl.Items.Add(this.FavouriteColor.Text.Substring(1, 2) +
                this.BirthYear.Text.Substring(2, 2) + this.txtLastName.Text);
        }
    }
}