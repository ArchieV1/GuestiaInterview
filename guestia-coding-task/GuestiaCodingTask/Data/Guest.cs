using System;

namespace GuestiaCodingTask.Data
{
    public class Guest
    {
        public int Id { get; set; }

        /// <summary>
        /// The guests first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The guests last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The date the guest registered in the platform. Will return null if the guest has not registered yet
        /// </summary>
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// The guest group that this guest is assigned to
        /// </summary>
        public GuestGroup GuestGroup { get; set; }
    }
}
