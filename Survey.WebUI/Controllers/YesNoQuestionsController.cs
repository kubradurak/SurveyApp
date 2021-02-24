using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Survey.Business.Abstract;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.WebUI.Controllers
{
    public class YesNoQuestionsController : Controller
    {
        private IYesNoQuestionService yesNoQuestionService;
        private IPollService pollService;

        public YesNoQuestionsController(IYesNoQuestionService yesNoQuestionService, IPollService pollService)
        {
            this.yesNoQuestionService = yesNoQuestionService;
            this.pollService = pollService;
        }
        public IActionResult Index()
        {
            var questions = yesNoQuestionService.GetQuestions();
            return View(questions);
        }

        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yesNoQuestion = yesNoQuestionService.GetQuestionById(id);
            if (yesNoQuestion == null)
            {
                return NotFound();
            }

            return View(yesNoQuestion);
        }


        public IActionResult Create()
        {
            List<SelectListItem> selectListItems = GetSurveysForSelect();
            ViewBag.Items = selectListItems;
            return View();
        }


        [HttpPost]
        public IActionResult Create(YesNoQuestion yesNoQuestion)
        {

            if (ModelState.IsValid)
            {
                yesNoQuestionService.AddQuestion(yesNoQuestion);
                return RedirectToAction(nameof(Index));
            }
            return View(yesNoQuestion);
        }
        private List<SelectListItem> GetSurveysForSelect()
        {
            var categories = pollService.GetPolls();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            categories.ToList().ForEach(c => selectListItems.Add(new SelectListItem
            {
                Text = c.Title,
                Value = c.Id.ToString()
            }
            ));
            return selectListItems;
        }
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yesNoQuestion = yesNoQuestionService.GetQuestionsByPollId(id);
            if (yesNoQuestion == null)
            {
                return NotFound();
            }
            return View(yesNoQuestion);
        }


        [HttpPost]
        public IActionResult Edit(YesNoQuestion yesNoQuestion)
        {
            if (ModelState.IsValid)
            {
                yesNoQuestionService.UpdateQuestion(yesNoQuestion);
                return RedirectToAction(nameof(Index));
            }
            return View(yesNoQuestion);
        }

        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yesNoQuestion = yesNoQuestionService.GetQuestionById(id);
            if (yesNoQuestion == null)
            {
                return NotFound();
            }

            return View(yesNoQuestion);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var yesNoQuestion = yesNoQuestionService.DeleteQuestion(id);
            return RedirectToAction(nameof(Index));
        }
    }
}