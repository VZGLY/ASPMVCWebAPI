using DAL.Context;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User Create(User user)
        {
            user.Id = FakeDb.Users.Max(x => x.Id) + 1;
            FakeDb.Users.Add(user);
            return user;
        }

        public bool Delete(int id)
        {
            User? userToDelete = FakeDb.Users.Find(x => x.Id == id);

            if (userToDelete is null) 
            {
                return false;
            }

            FakeDb.Users.Remove(userToDelete);

            return true;
        }

        public IEnumerable<User> GetAll()
        {
            return FakeDb.Users;
        }

        public User GetById(int id)
        {
            return FakeDb.Users.Find(x => x.Id == id)!;
        }

        public bool Update(User user)
        {
            User? userToUpdate = FakeDb.Users.Find(x => x.Id == user.Id);

            if (userToUpdate is null)
            {
                return false;
            }

            FakeDb.Users.Insert(FakeDb.Users.IndexOf(userToUpdate), user);
            FakeDb.Users.Remove(userToUpdate);
            return true;
        }
    }
}
