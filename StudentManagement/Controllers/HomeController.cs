using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bar()
        {
            var markList= GetStudentMarkList();
            return View(markList);
        }
        public IActionResult Line()
        {
            var markList = GetStudentMarkList();
            return View(markList);
        }

        public IActionResult Doughnut()
        {
            var scoreList = GetStudentScoreDetails();
            return View(scoreList);
        }


        public List<StudentMarkDetails> GetStudentMarkList()
        {
            var studentmarkList = new List<StudentMarkDetails>()
            {
                new StudentMarkDetails() { id = 1, name = "Vinh", Physics = 62,Chemistry=78,Biology=84,Mathematics=96 },
                new StudentMarkDetails() { id = 2, name = "Hào", Physics = 96,Chemistry=78,Biology=69,Mathematics=88 },
                new StudentMarkDetails() { id = 3, name = "Trung", Physics = 49,Chemistry=85,Biology=63,Mathematics=77 },
                new StudentMarkDetails() { id = 4, name = "Hiếu", Physics = 85,Chemistry=56,Biology=78,Mathematics=55 },
                new StudentMarkDetails() { id = 5, name = "Lành", Physics = 74,Chemistry=55,Biology=36,Mathematics=69 },
                new StudentMarkDetails() { id = 6, name = "Trang", Physics = 90,Chemistry=65,Biology=36,Mathematics=80 },
            };
            return studentmarkList;
        }
        public List<StudentScoreDetails> GetStudentScoreDetails()
        {
            var studentscoreList = new List<StudentScoreDetails>()
            {
                new StudentScoreDetails() { id = 1, name = "Vinh", score = 62},
                new StudentScoreDetails() { id = 2, name = "Hào", score = 96 },
                new StudentScoreDetails() { id = 3, name = "Trung", score = 49 },
                new StudentScoreDetails() { id = 4, name = "Hiếu", score = 85 },
                new StudentScoreDetails() { id = 5, name = "Lành", score = 74},
                new StudentScoreDetails() { id = 6, name = "Trang", score = 90},
            };
            return studentscoreList;
        }

    }
}
