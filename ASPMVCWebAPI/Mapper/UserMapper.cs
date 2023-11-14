

using ASPMVCWebAPI.Models;

namespace ASPMVCWebAPI.Mapper
{
    public static class UserMapper
    {

        public static User ToUser(this UserFormViewModel source, int? id = null)
        {
            return new User(id == null ? 0 : (int)id, source.Email, source.Firstname, source.Lastname);
        }

        public static UserFormViewModel ToViewModel(this User source) 
        {
            return new UserFormViewModel
            {
                Email = source.Email,
                Firstname = source.Firstname,
                Lastname = source.Lastname,
            };
        }

    }
}
