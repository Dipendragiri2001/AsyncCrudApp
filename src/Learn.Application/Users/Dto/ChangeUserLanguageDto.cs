using System.ComponentModel.DataAnnotations;

namespace Learn.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}