using Microsoft.AspNetCore.Mvc;
using Survey.Business.Abstract;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.WebUI.Controllers
{
    public class VotedController : Controller
    {
        private IPollService pollService;
        private IUserSurveysService userSurveysService;
        private IUserService userService;

        public VotedController(IPollService pollService,
            IUserService userService,
            IUserSurveysService userSurveysService)
        {
            this.pollService = pollService;
            this.userSurveysService = userSurveysService;
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ToBeVotedSurveys()
        {
            foreach (var poll in pollService.GetPolls())
            {
                var userName = User.Identity.Name;
                var user = userService.GetUserByUserName(userName);
                var IsVotedPoll = userSurveysService.CheckVotedUser(user.Id,poll.Id);

                if (IsVotedPoll == true)
                {
                    // anketi cevplamış ekranda görüntüleyemeyceğiz

                }

            }

            //var IsVotedPoll = userSurveysService.CheckVotedUser();
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
    }
}
