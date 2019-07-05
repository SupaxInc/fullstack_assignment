using System.ComponentModel.DataAnnotations;

namespace assignment.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}