using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_Demo_MyFirstMVC.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "Bienvenue le controller Hello!";
        }

        public string Saluer(string username)
        {
            return $"Bonjour {username}";
        }

        [Route("Hello/Count/{nb?}")]
        [Route("Hello/Compter/{nb?}")]
        public string Compter(int nb) {
            string result = "";
            for (int i = 0; i < nb; i++)
            {
                result += $"{i},";
            }
            result += nb;
            return result;
        }

        [Route("Hello/CompterDe/{nb}/A/{nb2}")]
        public string Compter(int nb, int nb2)
        {
            string result = "";
            for (int i = nb; i < nb2; i++)
            {
                result += $"{i},";
            }
            result += nb2;
            return result;
        }
    }
}
