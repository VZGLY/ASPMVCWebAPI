using BLL.Models.Forms;
using BLL.Models.ViewModels;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel ToViewModel(this User user)
        {
            return new UserViewModel
            {
                Email = user.Email,
                Id = user.Id,
                LastConnection = user.LastConnection,
                Name = user.Name,
            };
        }

        public static User ToUser(this CreateUserForm createUserForm)
        {
            return new User
            {
                Id = 0,
                Email = createUserForm.Email,
                Name = createUserForm.Name,
                Password = createUserForm.Password,
                CreationDate = DateTime.Now,
                LastConnection = DateTime.Now
            };
        }

        public static UpdateUserForm ToUpdateForm(this UserViewModel model)
        {
            return new UpdateUserForm
            {
                Id = model.Id,
                Email = model.Email,
                Name = model.Name,
                Password = ""
            };
        }


    }
}
