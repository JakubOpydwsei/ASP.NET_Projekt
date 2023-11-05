using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Labolatorium3_app.Models
{

    
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }

        [HiddenInput]             //PUNKT 4
        [Display(Name = "Data utworzenia")]
        public DateTime Created {  get; set; }

        [Required(ErrorMessage ="Musisz podać imię!")]
        [StringLength(maximumLength:50, ErrorMessage ="Zbyt długie imię, max 50 znaków!")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [EmailAddress]
        [Display(Name = "Adres Email")]
        public string Email { get; set; }

        [Display(Name = "Numer telefonu")]
        public string? Phone { get; set; }  //pole opcjonalne

        [Display(Name = "Data urodzenia")]
        public DateTime? Birth { get; set; }    //pole opcjonalne

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        



    }
}
