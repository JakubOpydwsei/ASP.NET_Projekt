using Labolatorium3_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_app.Models
{

    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imię, max 50 znaków!")]
        [Display(Name = "Imię:")]
        public string Name { get; set; }
        [EmailAddress]
        [Display(Name = "Email:")]
        public string Email { get; set; }
        [Display(Name = "Telefon:")]
        public string? Phone { get; set; }
        [Display(Name = "Data urodzenia:")]
        public DateTime? Birth { get; set; }
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        public int OrganizationId { get; set; }

        [ValidateNever]
        public List<SelectListItem> Organizations { get; set; }

    }
}
