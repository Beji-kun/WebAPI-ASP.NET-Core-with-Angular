using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string PasswordSeed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime LastActive { get; set; }

    }
}
