using System.ComponentModel.DataAnnotations;

namespace lab2___filmy.Models
{
    public class Dane
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2, ErrorMessage = "Imie musi zawierac co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi zawierac co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Hasło")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej 8 znaków, w tym jedną cyfrę, jedną wielką literę i jedną małą literę")]
        public string Hasło { get; set; }

        [Required(ErrorMessage = "Prosze potwierdz Hasło")]
        [Compare("Hasło", ErrorMessage = "Hasła nie są takie same")]
        public string PotwierdzHasło { get; set; }

        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string Temat { get; set; }

        [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string Tresc { get; set; }
    }
}