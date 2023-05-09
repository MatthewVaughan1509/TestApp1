using System;

/// <summary>
/// This is a domain class. It provides a representation of a database table and its properties
/// will exactly map to a database table.
/// Object Relation Mapping is provided by Dapper which is available on Nu Get and is used throught all of our applications.
/// </summary>
namespace DataModel.Domain
{
    public class Person
    {
        public int Id { get; set; }

        /// <summary>
        /// Full Name
        /// </summary>
        public string FullName { get; set; }
        
        /// <summary>
        /// Date of Birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}
