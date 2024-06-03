using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelASPCORE.Models;
 



namespace ViewModelASPCORE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student {Id = 1, Name = "Abhishek", Gender = "Male", Standard = 12},
                new Student {Id = 2, Name = "Ayush", Gender = "Male", Standard = 11},
                new Student {Id = 3, Name = "aryan", Gender = "Male", Standard = 11},
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher {Id = 1, Name = "Sagar", Qualification = "B.Tech", Salary = 12000},
                new Teacher {Id = 2, Name = "Sikhar", Qualification = "MS", Salary = 10001},
                new Teacher {Id = 3, Name = "Sanjay", Qualification = "MBA", Salary = 11314},
            };

             

            SchoolViewModel svm = new SchoolViewModel()
            {
                myStudents = students,
                myTeachers = teachers
            };

            return View(svm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
