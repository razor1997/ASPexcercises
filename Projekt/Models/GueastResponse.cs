using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Projekt.Models
{
    public class GueastResponse
    {
        [Required(ErrorMessage ="Proszę podać swoje imię i nazwisko.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Proszę podać swój email adres")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage ="Proszę podać prawidłowy adres e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Podaj swój numer telefonu")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Proszę się okreslić co Pana/Panią interesuje")]
        public bool? WillAttend { get; set; }
    }
} 