

using ASPMVCWebAPI.Models;

namespace ASPMVCWebAPI.Context
{
    public static class FakeDB
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User(1, "Pol.ice@gmail.com", "pol", "ice"),
    new User(2, "Sophie.sweet@gmail.com", "sophie", "sweet"),
    new User(3, "Antoine.adventurer@gmail.com", "antoine", "adventurer"),
    new User(4, "Marie.creative@gmail.com", "marie", "creative"),
    new User(5, "Julien.passionate@gmail.com", "julien", "passionate"),
    new User(6, "Charlotte.dreamer@gmail.com", "charlotte", "dreamer"),
    new User(7, "William.fighter@gmail.com", "william", "fighter"),
    new User(8, "Alexia.warrior@gmail.com", "alexia", "warrior"),
    new User(9, "Benjamin.lover@gmail.com", "benjamin", "lover"),
    new User(10, "Sarah.friend@gmail.com", "sarah", "friend"),
    new User(11, "Vincent.supporter@gmail.com", "vincent", "supporter"),
    new User(12, "Amélie.teamwork@gmail.com", "amelie", "teamwork"),
    new User(13, "Lucas.explorer@gmail.com", "lucas", "explorer"),
    new User(14, "Chloé.dancer@gmail.com", "chloe", "dancer"),
    new User(15, "Gabriel.singer@gmail.com", "gabriel", "singer"),
    new User(16, "Emma.artist@gmail.com", "emma", "artist"),
    new User(17, "Léo.gamer@gmail.com", "leo", "gamer"),
    new User(18, "Clément.scientist@gmail.com", "clement", "scientist"),
    new User(19, "Inès.doctor@gmail.com", "ines", "doctor"),
    new User(20, "Mathis.engineer@gmail.com", "mathis", "engineer"),
    new User(21, "Noah.lawyer@gmail.com", "noah", "lawyer"),
    new User(22, "Louise.teacher@gmail.com", "louise", "teacher"),
    new User(23, "Adam.police@gmail.com", "adam", "police"),
    new User(24, "Éloïse.firefighter@gmail.com", "eloise", "firefighter"),
    new User(25, "Hugo.soldier@gmail.com", "hugo", "soldier"),
        };

        public static User AddWithIdentity(this List<User> source, User user)
        {
            user.Id = Users.Max(x => x.Id) + 1;
            Users.Add(user);
            return user;
        }

        public static bool Update(this List<User> source, User user)
        {
            User element = source.Find(x => x.Id == user.Id);
            if (element is null)
            {
                return false;
            }

            element.Firstname = user.Firstname;
            element.Lastname = user.Lastname;
            element.Email = user.Email;

            return true;
        }
    }
}
