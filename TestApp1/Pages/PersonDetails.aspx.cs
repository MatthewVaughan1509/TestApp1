using Service.Implementations; // Remove me.
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace TestApp1.Pages
{
    public partial class PersonDetails : System.Web.UI.Page
    {
        private IPersonService _personService;
        protected List<DateTime> _gridDataSource;

        public PersonDetails()
        {
            _personService = new PersonService();
        }

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
                _gridDataSource = _personService.GetAllDatesToNextBirthday(birthday);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}