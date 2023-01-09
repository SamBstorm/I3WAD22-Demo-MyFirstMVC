using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_Demo_MyFirstMVC.Models
{
    public class LoginForm
    {
        [Required(ErrorMessage = "L'email est obligatoire.")]
        [EmailAddress(ErrorMessage = "L'email n'est pas au bon format.")]
        [DisplayName("Courriel : ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
        //[RegularExpression("[0-9]")]
        //[RegularExpression("[a-z]")] //Erreur lorsque l'on ajoute 2 fois le même attribut... (continuer à utiliser des méthodes static custom dans le controlleur...
        [MinLength(4, ErrorMessage = "Le mot de passe est trop court.")]
        [MaxLength(32, ErrorMessage = "Le mot de passe est trop long.")]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe : ")]
        public string Passwd { get; set; }
    }
}
