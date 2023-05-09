using DataModel.Domain;
using DataModel.Domain.Custom;
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Service.Implementations
{
    /// <summary>
    /// This is the implementation of a ervice class. These are used extensiveley in my present role.
    /// Business logic goes here and they implement separation of concernes.
    /// </summary>
    public class PersonService : IPersonService
    {
        private static readonly string _lowerCaseVowles = "aeiou";

        /// <summary>
        /// This method will calculate how many days until the next birthday based upon the birthday parameter.
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int DaysTillNextBirthday(DateTime birthday)
        {
            var nextBirthday = GetNextBirthday(birthday);
            return (nextBirthday - DateTime.Today).Days;
        }

        /// <summary>
        /// This method uses the date time parameter to calulate a persons age and returns the value.
        /// Subtract one from the age value if the birthday has not been
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetAgeOfPerson(DateTime birthday)
        {
            int age;
            age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age = age - 1;
            return age;
        }

        /// <summary>
        /// This will calculate your next birthday based on the parameter value.
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        private DateTime GetNextBirthday(DateTime birthday)
        {
            var tempDate = new DateTime(DateTime.Today.Year, birthday.Month, birthday.Day);
            var nextBirthdayYear = tempDate > DateTime.Today ? tempDate.Year : tempDate.Year + 1;
            var nextBirthday = new DateTime(nextBirthdayYear, birthday.Month, birthday.Day);
            return nextBirthday;
        }

        public PersonQuery GetPersonDetails(Person person)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method counts the number of vowles in the string parameter.
        /// A null value will return zero and also the null check prevents null pointer exceptions.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int NumberOfVowles(string str)
        {
            if (str == null)
                return 0;

            var vowelCount = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (_lowerCaseVowles.Contains(str[i].ToString()))
                    vowelCount++;
            }

            return vowelCount;
        }

        /// <summary>
        /// This method will return a collection of date time values. One entry for each date between now and the next birthday.
        /// This method includes the current date in the result collection.
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<PersonQuery> GetAllDatesToNextBirthday(DateTime birthday)
        {
            var results = new List<PersonQuery>();
            var nextBirthday = GetNextBirthday(birthday);
            var date = DateTime.Today;
            while (date <= nextBirthday)
            {
                results.Add(new PersonQuery() { Date = date, Url = $"https://www.historynet.com/today-in-history/{date.ToString("MMM")}-{date.Day}" });
                date = date.AddDays(1);
            }
            return results;
        }
    }
}
