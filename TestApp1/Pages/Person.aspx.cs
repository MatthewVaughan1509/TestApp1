using System;

namespace TestApp1.Pages
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var dob = DateOfBirth.Text;
            var fullName = FullName.Text;
            var url = $"~/Pages/PersonDetails.aspx?fullname={fullName}&dateOfBirth={dob}";
            Response.Redirect(url);
        }
    }
}