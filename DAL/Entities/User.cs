using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        public User(int id, string email, string name, string password, DateTime creationDate, DateTime lastConnection)
        {
            Id = id;
            Email = email;
            Name = name;
            Password = password;
            CreationDate = creationDate;
            LastConnection = lastConnection;
        }

        public int Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastConnection { get; set; }

    }
}
