using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_Demo_MyFirstMVC.Models
{
    public class HomeIndexViewModel
    {
        public string Title { get; set; }
        public List<Student> Students { get; set; }
        public string Footer_tel { get; set; }
        public string Footer_email { get; set; }

        public HomeIndexViewModel(string title, IEnumerable<Student> students, string tel, string email)
        {
            Students = new List<Student>();
            foreach (Student student in students)
            {
                Students.Add(student);
            }
            Title = title;
            Footer_email = email;
            Footer_tel = tel;
        }
    }
}
