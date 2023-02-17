using GuestiaCodingTask.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuestiaCodingTask.Data
{
    class DbInitialiser
    {
        /// <summary>
        /// Creates and populates the database required for this task
        /// </summary>
        internal static void CreateDb()
        {
            var context = new GuestiaContext();

            context.Database.Migrate();

            if (!context.Guests.Any())
            {
                List<Guest> guestList = GetGuestList();

                guestList.ForEach(x => context.Guests.Add(x));

                context.SaveChanges();
            }
        }


        private static List<Guest> GetGuestList()
        {
            var standardGuestGroup = new GuestGroup
            {
                Name = "Standard",
                NameDisplayFormat = NameDisplayFormatType.LastNameCommaFirstNameInitial
            };

            var vipGuestGroup = new GuestGroup
            {
                Name = "VIP",
                NameDisplayFormat = NameDisplayFormatType.UpperCaseLastNameSpaceFirstName
            };

            return new List<Guest>
            {
                new Guest {
                    FirstName = "Maria",
                    LastName = "Anders",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                 new Guest {
                    FirstName = "Ana",
                    LastName = "Trujillo",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Antonio",
                    LastName = "Moreno",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Thomas",
                    LastName = "Hardy",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Christina",
                    LastName = "Berglund",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Hanna",
                    LastName = "Moos",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Frédérique",
                    LastName = "Citeaux",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Martín",
                    LastName = "Sommer",
                    GuestGroup = vipGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                    },
                new Guest {
                    FirstName = "Laurence",
                    LastName = "Lebihans",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Elizabeth",
                    LastName = "Lincoln",
                    GuestGroup = vipGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Victoria",
                    LastName = "Ashworth",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Patricio",
                    LastName = "Simpson",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Francisco",
                    LastName = "Chang",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Yang",
                    LastName = "Wang",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Pedro",
                    LastName = "Afonso",
                    GuestGroup = vipGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Elizabeth",
                    LastName = "Brown",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Sven",
                    LastName = "Ottlieb",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Janine",
                    LastName = "Labrune",
                    GuestGroup = vipGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Ann",
                    LastName = "Devon",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Roland",
                    LastName = "Mendel",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Aria",
                    LastName = "Cruz",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Diego",
                    LastName = "Roel",
                    GuestGroup = vipGuestGroup
                },
                new Guest {
                    FirstName = "Martine",
                    LastName = "Rancé",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Maria",
                    LastName = "Larsson",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                    },
                new Guest {
                    FirstName = "Peter",
                    LastName = "Franken",
                    GuestGroup = vipGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Carine",
                    LastName = "Schmitt",
                    GuestGroup = vipGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Paolo",
                    LastName = "Accorti",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Lino",
                    LastName = "Rodriguez",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Eduardo",
                    LastName = "Saavedra",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "José Pedro",
                    LastName = "Freyre",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "André",
                    LastName = "Fonseca",
                    GuestGroup = vipGuestGroup
                },
                new Guest {
                    FirstName = "Howard",
                    LastName = "Snyder",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Manuel",
                    LastName = "Pereira",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Mario",
                    LastName = "Pontes",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Carlos",
                    LastName = "Hernández",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Yoshi",
                    LastName = "Latimer",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Patricia",
                    LastName = "McKenna",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Helen",
                    LastName = "Bennett",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Philip",
                    LastName = "Cramer",
                    GuestGroup = vipGuestGroup
                },
                new Guest {
                    FirstName = "Daniel",
                    LastName = "Tonini",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Annette",
                    LastName = "Roulet",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Yoshi",
                    LastName = "Tannamuri",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "John",
                    LastName = "Steel",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Renate",
                    LastName = "Messner",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Jaime",
                    LastName = "Yorres",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Carlos",
                    LastName = "González",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Felipe",
                    LastName = "Izquierdo",
                    GuestGroup = vipGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Fran",
                    LastName = "Wilson",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Giovanni",
                    LastName = "Rovelli",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Catherine",
                    LastName = "Dewey",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Jean",
                    LastName = "Fresnière",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Alexander",
                    LastName = "Feuer",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Simon",
                    LastName = "Crowther",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Yvonne",
                    LastName = "Moncada",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Rene",
                    LastName = "Phillips",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Henriette ",
                    LastName = "Pfalzheim",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Marie",
                    LastName = "Bertrand",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Guillermo",
                    LastName = "Fernández",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Georg",
                    LastName = "Pipps",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Isabel",
                    LastName = "de Castro",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Bernardo",
                    LastName = "Batista",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Lúcia",
                    LastName = "Carvalho",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Horst",
                    LastName = "Kloss",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Sergio",
                    LastName = "Gutiérrez",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Paula",
                    LastName = "Wilson",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Maurizio",
                    LastName = "Moroni",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Janete",
                    LastName = "Limeira",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Michael",
                    LastName = "Holz",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Alejandra",
                    LastName = "Camino",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Jonas",
                    LastName = "Bergulfsen",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Jose",
                    LastName = "Pavarotti",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Hari",
                    LastName = "Kumar",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Jytte",
                    LastName = "Petersen",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Dominique",
                    LastName = "Perrier",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Art",
                    LastName = "Braunschweiger",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Pascale",
                    LastName = "Cartrain",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Liz",
                    LastName = "Nixon",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Liu",
                    LastName = "Wong",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Karin",
                    LastName = "Josephs",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Miguel Angel",
                    LastName = "Paolino",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Anabela",
                    LastName = "Domingues",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Helvetius",
                    LastName = "Nagy",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Palle",
                    LastName = "Ibsen",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Mary",
                    LastName = "Saveley",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Paul",
                    LastName = "Henriot",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Rita",
                    LastName = "Müller",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Pirkko",
                    LastName = "Koskitalo",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Paula",
                    LastName = "Parente",
                    GuestGroup = standardGuestGroup,
                    RegistrationDate = DateTime.UtcNow
                },
                new Guest {
                    FirstName = "Karl",
                    LastName = "Jablonski",
                    GuestGroup = standardGuestGroup
                },
                new Guest {
                    FirstName = "Matti",
                    LastName = "Karttunen",
                    GuestGroup = standardGuestGroup
                }
            };
        }
    }
}
