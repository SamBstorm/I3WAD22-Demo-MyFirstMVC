using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_Demo_MyFirstMVC.Models.StudentViewModel
{
    public class StudentDelete
    {
        [DisplayName("Nom de famille :")]
        public string Nom { get; set; }
        [DisplayName("Prénom :")]
        public string Prenom { get; set; }
        [DisplayName("Courriel :")]
        public string Email { get; set; }
    }
}
