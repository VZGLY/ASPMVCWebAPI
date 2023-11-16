using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        User Create(User user);

        bool Update(User user);

        bool Delete(int id);
    }
}
