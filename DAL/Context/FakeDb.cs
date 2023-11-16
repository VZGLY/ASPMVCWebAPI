using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public static class FakeDb
    {

        public static List<User> Users { get; set; } = new List<User>()
        {
            new User(1, "Murielle.Robin@Comedie.fr", "Mumu", "Test123=", DateTime.Now.AddDays(-124), DateTime.Now.AddDays(-7)),
            new User(2, "Arnaud.Ducret@Comedie.fr", "Arno", "Test123456", DateTime.Now.AddDays(-294), DateTime.Now.AddDays(-135)),
            new User(3, "Jean-Michel.Ribes@Comedie.fr", "JeanMi", "Azerty123", DateTime.Now.AddDays(-138), DateTime.Now.AddDays(-22)),
            new User(4, "Fabrice.Eboue@Comedie.fr", "Fabrice", "Qwerty1234", DateTime.Now.AddDays(-70), DateTime.Now.AddDays(-54)),
            new User(5, "Elie.Semoun@Comedie.fr", "Elie", "Motdepasse123", DateTime.Now.AddDays(-267), DateTime.Now.AddDays(-181)),
            new User(6, "Franck.Dubosc@Comedie.fr", "Franck", "123456Azerty", DateTime.Now.AddDays(-402), DateTime.Now.AddDays(-279)),
            new User(7, "Florence.Foresti@Comedie.fr", "Florence", "Azerty56789", DateTime.Now.AddDays(-315), DateTime.Now.AddDays(-242)),
            new User(8, "Gad.Elmaleh@Comedie.fr", "Gad", "Azerty123456789", DateTime.Now.AddDays(-385), DateTime.Now.AddDays(-262)),
            new User(9, "Guillaume.Canet@Comedie.fr", "Guillaume", "Motdepasse123456", DateTime.Now.AddDays(-162), DateTime.Now.AddDays(-108)),
            new User(10, "Jean-Pierre.Bacri@Comedie.fr", "JeanPi", "AzertyQwerty123", DateTime.Now.AddDays(-224), DateTime.Now.AddDays(-161)),
            new User(11, "Jamel.Debbouze@Comedie.fr", "Jamel", "Azerty12345678", DateTime.Now.AddDays(-196), DateTime.Now.AddDays(-142)),
            new User(12, "Laurent.Gerra@Comedie.fr", "Laurent", "AzertyQwerty1234", DateTime.Now.AddDays(-280), DateTime.Now.AddDays(-217)),
            new User(13, "Omar.Sy@Comedie.fr", "Omar", "Motdepasse12345", DateTime.Now.AddDays(-154), DateTime.Now.AddDays(-100)),
            new User(14, "Pierre.Richard@Comedie.fr", "Pierre", "Azerty1234567", DateTime.Now.AddDays(-333), DateTime.Now.AddDays(-250)),
            new User(15, "Richard.Anconina@Comedie.fr", "Richard", "Motdepasse1234", DateTime.Now.AddDays(-357), DateTime.Now.AddDays(-274)),
            new User(16, "Samy.Naceri@Comedie.fr", "Samy", "Azerty123", DateTime.Now.AddDays(-245), DateTime.Now.AddDays(-182)),
            new User(17, "Sophie.Marceau@Comedie.fr", "Sophie", "Qwerty123456", DateTime.Now.AddDays(-189), DateTime.Now.AddDays(-136)),
            new User(18, "Yann.Moix@Comedie.fr", "Yann", "Azerty12345", DateTime.Now.AddDays(-210), DateTime.Now.AddDays(-157)),
            new User(19, "Yves.Montand@Comedie.fr", "Yves", "AzertyQwerty12345", DateTime.Now.AddDays(-420), DateTime.Now.AddDays(-297))
        };
    }
}
