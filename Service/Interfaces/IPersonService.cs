using DataModel.Domain;
using DataModel.Domain.Custom;
using System;

namespace Service.Interfaces
{
    public interface IPersonService
    {
        PersonQuery GetPersonDetails(Person person);
        int NumberOfVowles(string str);
        int DaysTillNextBirthday(DateTime birthday);
        int GetAgeOfPerson(DateTime birthday);
    }
}
