using System;
using System.Collections.Generic;

namespace DataModel.Domain.Custom
{
    /// <summary>
    /// This is a custom class. Its properties will map to the output of a database query or service method.
    /// </summary>
    public class PersonQuery
    {
        public PersonQuery()
        {
            LinksToWebsiteByDate = new Dictionary<DateTime, string>();
        }
        int Id { get; set; }
        string FirstName { get; set; }
        int NumberOfVowlesInFirstName { get; set; }
        Dictionary<DateTime, string> LinksToWebsiteByDate { get; set; }
    }
}
