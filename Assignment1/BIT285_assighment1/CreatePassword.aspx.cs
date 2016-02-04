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
        //The page gets the information about the Last Name and stores it.
        protected void Page_Load(object sender, EventArgs e)
        {
            txtLastName.Text = (string) Session["lastName"];       
        }
        
        //This method creates the different passwords with different combinations of letters and numbers. 
        //Also it uses AddRandomNUmbers method in order to create the password combinations not less than 8 characters, no white spaces. 
        protected void SuggestBtn_Click(object sender, EventArgs e)
        {
            this.SuggestionDdl.Items.Clear();
            this.SuggestionDdl.Items.Add(AddRandomNumbers(this.txtLastName.Text +
                this.FavouriteColor.Text + this.BirthYear.Text));
            this.SuggestionDdl.Items.Add(AddRandomNumbers(this.FavouriteColor.Text + this.FavouriteColor.Text +
                this.BirthYear.Text));
            this.SuggestionDdl.Items.Add(AddRandomNumbers(this.BirthYear.Text + this.txtLastName.Text +
                this.txtLastName.Text));
            this.SuggestionDdl.Items.Add(AddRandomNumbers(this.txtLastName.Text.Substring(0, 3) +
                this.BirthYear.Text.Substring(2, 2) + this.FavouriteColor.Text));
            this.SuggestionDdl.Items.Add(AddRandomNumbers(this.FavouriteColor.Text.Substring(1, 2) +
                this.BirthYear.Text.Substring(2, 2) + this.txtLastName.Text));
        }


        //It checks that there are not white spaces and that the password is 8 characters long.
        private string AddRandomNumbers(string input)
        {
            string inputModified = input.Replace(" ", "");
            if (inputModified.Length < 8)
            {
                Random r = new Random();
                int result = r.Next() % (int)Math.Pow(10, 8 - inputModified.Length);
                return inputModified + result; 
            }
            else
            {
                return inputModified;
            }
        }


    }
}