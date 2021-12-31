using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Student : Controller
    {
        public string Index()
        {
            return "Details About Student";

        }
        public string StudentId()
        {
            return "101";

        }
        public string StudentName()
        {
            return "Mohamed Safeudeen";

        }
    }
}
