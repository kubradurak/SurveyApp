using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Survey.Business.Abstract;
using Survey.Entities;
using Survey.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.WebUI.Controllers
{
    [Authorize(Roles = "Admin,User")]
    public class VotedController : Controller
    {
        private IPollService pollService;
        private IUserSurveysService userSurveysService;
        private IUserService userService;
        private IYesNoAnswerService yesNoAnswerService;

        public VotedController(IPollService pollService,
            IUserService userService,
            IYesNoAnswerService yesNoAnswerService,
            IUserSurveysService userSurveysService)
        {
            this.pollService = pollService;
            this.userSurveysService = userSurveysService;
            this.userService = userService;
            this.yesNoAnswerService = yesNoAnswerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ToBeVotedSurveys()
        {
            // filtrele istersen 
            return View(pollService.GetPolls());
        }

        public IActionResult MissedPolls()
        {
            var userName = User.Identity.Name;
            var user = userService.GetUserByUserName(userName);
            var missedPolls = userSurveysService.MissedPollsOfUser(user.Id);
            return View(missedPolls);
        }
        public IActionResult VotedPolls()
        {
            var userName = User.Identity.Name;
            var user = userService.GetUserByUserName(userName);
            var votedPolls = userSurveysService.VotedPollsOfUser(user.Id);
            return View(votedPolls);
        }

        public IActionResult Vote(int id)
        {
            var userName = User.Identity.Name;
            var user = userService.GetUserByUserName(userName);
            var IsVotedPoll = userSurveysService.CheckVotedUser(user.Id, id);
            if (IsVotedPoll == true)
            {
                return RedirectToAction("VotedPoll", "YesNoAnswers");

            }
            var poll = pollService.GetPollByIdForVote(id);
            return View(poll);
        }
        [HttpPost]
        public IActionResult Vote(PollDTO polDTO)
        {
            var userName = User.Identity.Name;
            var user = userService.GetUserByUserName(userName);       
            userSurveysService.Voted(polDTO, user);
            return View("ThanksForVoted");
        }
    }
}
