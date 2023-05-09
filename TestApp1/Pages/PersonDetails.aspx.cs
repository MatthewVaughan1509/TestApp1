using Ninject;
using Service.Interfaces;
using System;

namespace TestApp1.Pages
{
    public partial class PersonDetails : System.Web.UI.Page
    {

        /// <summary>
        /// Ninject provides this service. See NinjectWebCommon.cs for details.
        /// </summary>
        [Inject]
        public IPersonService _personService { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Request["fullname"] != null)
            {
                FirstName.Text = Request["fullname"].Split(' ')[0];
                NumberOfVowlesInYourFirstName.Text = _personService.NumberOfVowles(FirstName.Text).ToString();
                NumberOfVowlesInYourFullName.Text = _personService.NumberOfVowles(Request["fullname"]).ToString();
            }

            if (Request["dateOfBirth"] != null && DateTime.TryParse(Request["dateOfBirth"], out var birthday))
            {
                Age.Text = _personService.GetAgeOfPerson(birthday).ToString();
                DaysTillNextBirthday.Text = _personService.DaysTillNextBirthday(birthday).ToString();
                PersonGridView.DataSource = _personService.GetAllDatesToNextBirthday(birthday);
                PersonGridView.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void PersonGridView_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {            
            PersonGridView.PageIndex = e.NewPageIndex;
            PersonGridView.DataBind();
        }
    }
}