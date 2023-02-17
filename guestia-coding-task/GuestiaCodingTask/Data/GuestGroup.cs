using GuestiaCodingTask.Helpers;

namespace GuestiaCodingTask.Data
{
    public class GuestGroup
    { 
        public int Id { get; set; }

        /// <summary>
        /// The name of the guest group
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Defines how the name of guests in this group should be displayed 
        /// </summary>
        public NameDisplayFormatType NameDisplayFormat { get; set; }
    }
}
