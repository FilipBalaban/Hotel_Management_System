using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Guest
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        // For data from Views
        public Guest(string firstName, string lastName, int age, string email, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Country = country;
        }
        // For data from DB
        public Guest(int id, string firstName, string lastName, int age, string email, string country)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Country = country;
        }
    }
}
