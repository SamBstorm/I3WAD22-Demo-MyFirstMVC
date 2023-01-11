using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_Demo_MyFirstMVC.Models.StudentViewModel
{
    public class StudentDetails
    {
        [DisplayName("Nom de famille :")]
        public string Nom { get; set; }
        [DisplayName("Prénom :")]
        public string Prenom { get; set; }
        [DisplayName("Courriel :")]
        public string Email { get; set; }
        [DisplayName("Date de naissance :")]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }
    }
}
