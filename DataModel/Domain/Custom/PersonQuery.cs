using System;
using System.Collections.Generic;

namespace DataModel.Domain.Custom
{
    /// <summary>
    /// This is a custom class. Its properties will map to the output of a database query or service method.
    /// </summary>
    public class PersonQuery
    {
        public DateTime Date { get; set; }
        public String Url { get; set; }
    }
}
