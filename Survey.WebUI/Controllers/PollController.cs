using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Survey.Business.Abstract;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PollController : Controller
    {
        private IPollService pollService;
        private IYesNoQuestionService yesNoQuestionService;

        public PollController(IPollService pollService, IYesNoQuestionService yesNoQuestionService)
        {
            this.pollService = pollService;
            this.yesNoQuestionService = yesNoQuestionService;

        }
        public IActionResult Index()
        {
            var polls = pollService.GetPolls();
            return View(polls);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Poll poll)
        {
            if (ModelState.IsValid)
            {
                pollService.AddPoll(poll);
                return Redirect("/");

            }
            return View();
        }
        public IActionResult NewSurvey()
        {
            //exception fırlatıyor
            var polls = pollService.HaventQuestionPoll();
            return View(polls);
        }

        public IActionResult AddYesNoQuestion(int id)
        {
            // kullanılıyor mu incele
            var survey = pollService.GetPollById(id);
            ViewBag.SurveyId = survey.Id;
            ViewBag.SurveyTitle = survey.Title;
            return View();
        }
        [HttpPost]
        public IActionResult AddYesNoQuestion(YesNoQuestion yesNoQuestion, int id)
        {
            if (ModelState.IsValid)
            {
                var survey = pollService.GetPollById(id);
                yesNoQuestion.Poll = survey;
                yesNoQuestion.PollId = survey.Id;

                yesNoQuestionService.AddQuestion(yesNoQuestion);
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var existing = pollService.GetPollById(id);
            if (existing == null)
            {
                return NotFound();
            }
            return View(existing);

        }
        [HttpPost]
        public IActionResult Edit(Poll poll)
        {
            if (ModelState.IsValid)
            {
                pollService.Update(poll);
                return RedirectToAction(nameof(Index));

                // return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            // var category = categoryService.GetCategoryById(id);
            var survey = pollService.GetPollsForDetails(id);

            return View(survey);
        }
        public IActionResult Delete(int id)
        {
            var existing = pollService.GetPollById(id);
            if (existing == null)
            {
                return NotFound();
            }
            return View(existing);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteOk(int id)
        {
            var deleted = pollService.GetPollById(id);
            pollService.Delete(deleted);
            return RedirectToAction(nameof(Index));
        }



        public IActionResult ExpiredSurveys()
        {
            var surveys = pollService.GetPolls();
            return View(surveys);
        }
        public IActionResult ActiveSurveys()
        {
            var surveys = pollService.GetPolls();
            return View(surveys);
        }
    }
}