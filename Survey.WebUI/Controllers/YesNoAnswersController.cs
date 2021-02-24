using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Admin, User")]
    public class YesNoAnswersController : Controller
    {
        private IYesNoAnswerService yesNoAnswerService;
        private IPollService pollService;
        private IUserSurveysService userSurveysService;
        private IYesNoQuestionService yesNoQuestionService;
        private IUserService userService;

        public YesNoAnswersController(IYesNoAnswerService yesNoAnswerService,
            IPollService pollService,
            IUserService userService,
            IUserSurveysService userSurveysService,
            IYesNoQuestionService yesNoQuestionService)
        {
            this.yesNoAnswerService = yesNoAnswerService;
            this.pollService = pollService;
            this.userSurveysService = userSurveysService;
            this.yesNoQuestionService = yesNoQuestionService;
            this.userService = userService;

        }
        public IActionResult Index()
        {
            var questions = yesNoAnswerService.GetAnswers();
            //return View(questions);
            return View();
        }

        public IActionResult Details(int id)
        {

            return View();
        }

        public IActionResult Create(int id)
        {
            List<SelectListItem> selectListItems = GetQuestionForSelect();
            ViewBag.Items = selectListItems;

            var userName = User.Identity.Name;
            var user = userService.GetUserByUserName(userName);
            var IsVotedPoll = userSurveysService.CheckVotedUser(user.Id, id);
            if (IsVotedPoll == true)
            {
                return RedirectToAction(nameof(VotedPoll));

            }
          //  ViewBag.PollId = id;
            return View();
        }
        private List<SelectListItem> GetQuestionForSelect()
        {
            var categories = yesNoQuestionService.GetQuestions();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            categories.ToList().ForEach(c => selectListItems.Add(new SelectListItem
            {
                Text = c.Content,
                Value = c.Id.ToString()
            }
            ));
            return selectListItems;
        }

        [HttpPost]
        public IActionResult Create(YesNoAnswer yesNoAnswer)
        {
            if (ModelState.IsValid)
            {
                var a = yesNoAnswer.YesNoQuestionId;
                var pollId = pollService.GetPollByQuestionId(a); // pollId
                if (pollId == -1)
                {
                    return RedirectToAction(nameof(ErrorView));
                }
                var userName = User.Identity.Name;
                var user = userService.GetUserByUserName(userName); //userıd
                UserPoll userPoll = new UserPoll();
                userPoll.PollId = pollId;
                userPoll.UserId = user.Id;
                userSurveysService.Add(userPoll);


                yesNoAnswerService.AddYesNoAnswer(yesNoAnswer);
                return RedirectToAction("ToBeVotedSurveys", "Voted");

            }
            List<SelectListItem> selectListItems = GetQuestionForSelect();
            ViewBag.Items = selectListItems;
            return RedirectToAction("ToBeVotedSurveys","Voted");
        }
        public IActionResult ErrorView()
        {
            return View();
        }
        public IActionResult VotedPoll()
        {
            return View();
        }


        public IActionResult Edit(int? id)
        {
            return View();
        }


        [HttpPost]
        public IActionResult Edit(YesNoAnswer yesNoAnswer)
        {
            return View(yesNoAnswer);
        }

        public IActionResult Delete(int id)
        {

            return View();
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return RedirectToAction(nameof(Index));
        }

    }
}