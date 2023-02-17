using GuestiaCodingTask.Data;
using GuestiaCodingTask.Helpers;
using System;
using System.Linq;

namespace GuestiaCodingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DbInitialiser.CreateDb();

            // Assumptions:
            // How to order guests alphabetically wasn't specified. Chose by LastName as all formatting is LastName first
            // I wasn't sure about which other files I was meant to use so just used:
            //      Guest.cs, GuestGroup.cs and GuestiaContext.cs
            // Wasn't 100% sure how to print LastNameCommaFirstNameInitial so both are below
            
            // I could not install SqlServerExpress on my PC. I spent 2-3h troubleshooting it before giving up
            // (Windows 10 and Ubuntu 20.04 LTS)
            // Therefore this code has not been tested. There are likely minor issues though with a database connection
            // I am sure I could fix them quickly and they would be minor
            
            GuestiaContext context = new GuestiaContext();

            foreach (IGrouping<GuestGroup, Guest> guestGroupGuestDict in context.Guests.
                Where(g => g.RegistrationDate == null). // Remove all who have registered
                OrderBy(g => g.LastName). // Sort by last name
                GroupBy(g => g.GuestGroup)) // Group by VIP/Standard
            {
                Console.WriteLine($"'{guestGroupGuestDict.Key.Name}' guests who are yet to register:");
                
                foreach (Guest guest in guestGroupGuestDict)
                {
                    string toPrint;
                    // Forcing capitalisation is overkill but makes sure it is definitely formatted correctly no matter the data
                    if (guestGroupGuestDict.Key.NameDisplayFormat == NameDisplayFormatType.UpperCaseLastNameSpaceFirstName)
                    {
                        // LASTNAME FirstName
                        toPrint = $"{guest.LastName.ToUpper()} {guest.FirstName.Substring(0, 1).ToUpper()}{guest.FirstName.Substring(1, guest.FirstName.Length - 1)}";
                    }
                    else
                    {

                        // LastName, F
                        toPrint = $"{guest.LastName.Substring(0, 1).ToUpper()}{guest.LastName.Substring(1, guest.LastName.Length - 1).ToLower()}, {guest.FirstName.Substring(0, 1).ToUpper()}";

                        // I doubt this is what was meant but if it was here it is:
                        // LastName, F(irstName)
                        string toPrint2 = $"{guest.LastName}, " +
                                  $"{guest.FirstName.Substring(0, 1).ToUpper()}" +
                                  $"({guest.FirstName.Substring(1, guest.FirstName.Length - 1)})";

                    }
                    Console.WriteLine(toPrint);
                }
            }
        }
    }
}
