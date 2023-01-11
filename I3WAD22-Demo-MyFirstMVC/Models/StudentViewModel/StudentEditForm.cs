using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_Demo_MyFirstMVC.Models.StudentViewModel
{
    public class StudentEditForm
    {
        [DisplayName("Nom de famille :")]
        [Required]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Pas la bonne taille")]
        public string Nom { get; set; }
        [DisplayName("Prénom :")]
        [Required]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Pas la bonne taille")]
        public string Prenom { get; set; }
        [DisplayName("Courriel :")]
        [Editable(false)]
        public string Email { get; set; }
        [DisplayName("Date de naissance :")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }
    }
}
