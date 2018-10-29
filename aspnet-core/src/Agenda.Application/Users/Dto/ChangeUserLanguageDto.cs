using System.ComponentModel.DataAnnotations;

namespace Agenda.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}