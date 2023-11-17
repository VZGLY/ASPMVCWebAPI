using BLL.Models.Forms;
using BLL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        public int NbrOfUses { get; set; }

        public UserViewModel GetById(int id);
        
        public IEnumerable<UserViewModel> GetAll();

        public UserViewModel Create(CreateUserForm form);

        public bool Update(UpdateUserForm form);

        public bool Delete(int id);
    }
}
