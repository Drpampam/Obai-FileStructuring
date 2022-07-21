using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Models
{
    public class User
    {
        public User(string firstName, string lastName, string email, int id)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FullName 
        { 
            get { return FirstName + " " + LastName; }
        }
        public string Email { get; set; } = null!;
    }
}
