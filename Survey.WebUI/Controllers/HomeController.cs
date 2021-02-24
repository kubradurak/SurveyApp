using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Survey.Business.Abstract;
using Survey.Business.Concrete;
using Survey.Entities;
using Survey.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //Business katmanında çağır metodları
        private readonly ILogger<HomeController> _logger;
        private  IPollService pollService;
        private IUserService userService;

        public HomeController(ILogger<HomeController> logger, IPollService pollService, IUserService userService )
        {
            _logger = logger;
            this.pollService = pollService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            var polls = pollService.GetPolls();

            return View(polls);
        }
        public IActionResult ShowSurvey(int id)
        {
            var questions = pollService.GetPollsForDetails(id);
            var questionList = new List<SurveyDTO>();
            foreach (var question in questions.YesNoQuestions)
            {
                questionList.Add(new SurveyDTO()
                {

                    YesNoQuestionId = question.Id,
                    Question = question.Content,

                });
            }
            return View(questionList);

        }
        [HttpPost]
        public IActionResult ShowSurvey(List<SurveyDTO> questions)
        {
            var count = questions.Count();

            return View();
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
