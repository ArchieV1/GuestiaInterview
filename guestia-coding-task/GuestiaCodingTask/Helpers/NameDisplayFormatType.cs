using System.ComponentModel.DataAnnotations;

namespace GuestiaCodingTask.Helpers
{
    public enum NameDisplayFormatType
    {
        [Display(Name = "LASTNAME FirstName")]
        UpperCaseLastNameSpaceFirstName,
        [Display(Name = "LastName, F(irstName)")]
        LastNameCommaFirstNameInitial
    }
}
