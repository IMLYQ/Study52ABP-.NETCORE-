using System.ComponentModel.DataAnnotations;

namespace Study52ABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}