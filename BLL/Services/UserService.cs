using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models.Forms;
using BLL.Models.ViewModels;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int NbrOfUses { get; set; } = 0;

        public UserViewModel Create(CreateUserForm form)
        {
            NbrOfUses++;

            form.Password = BCrypt.Net.BCrypt.HashPassword(form.Password);

            return _userRepository.Create(form.ToUser()).ToViewModel();
        }

        public bool Delete(int id)
        {
            NbrOfUses++;
            return _userRepository.Delete(id);
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            NbrOfUses++;
            Console.WriteLine(NbrOfUses);
            return _userRepository.GetAll().Select(x => x.ToViewModel());
        }

        public UserViewModel GetById(int id)
        {
            NbrOfUses++;
            return _userRepository.GetById(id).ToViewModel();
        }

        public bool Update(UpdateUserForm form)
        {
            NbrOfUses++;

            User user = _userRepository.GetById(form.Id);

            if (user is null)
            {
                return false;
            }

            Console.WriteLine(BCrypt.Net.BCrypt.Verify(form.Password, user.Password));

            user.Name = form.Name;
            user.Email = form.Email;
            if (!string.IsNullOrEmpty(form.Password))
            {
                user.Password =  BCrypt.Net.BCrypt.HashPassword(form.Password);
            }
            user.LastConnection = DateTime.Now;

            return _userRepository.Update(user);
        }
    }
}
