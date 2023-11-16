using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models.Forms;
using BLL.Models.ViewModels;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public UserViewModel Create(CreateUserForm form)
        {
            return _userRepository.Create(form.ToUser()).ToViewModel();
        }

        public bool Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            return _userRepository.GetAll().Select(x => x.ToViewModel());
        }

        public UserViewModel GetById(int id)
        {
            return _userRepository.GetById(id).ToViewModel();
        }

        public bool Update(UpdateUserForm form)
        {
            User user = _userRepository.GetById(form.Id);

            if (user is null)
            {
                return false;
            }

            user.Name = form.Name;
            user.Email = form.Email;
            if (!string.IsNullOrEmpty(form.Password))
            {
                user.Password =  form.Password;
            }
            user.LastConnection = DateTime.Now;

            return _userRepository.Update(user);
        }
    }
}
