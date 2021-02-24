using Survey.Business.Abstract;
using Survey.DataAccess.Abstract;
using Survey.Entities;
using Survey.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Concrete
{
    public class UserSurveysManager : IUserSurveysService
    {
        private IUserSurveysDal userSurveysDal;
        private IYesNoAnswerDal yesNoAnswerDal;

        public UserSurveysManager(IUserSurveysDal userSurveysDal, 
            IYesNoAnswerDal yesNoAnswerDal)
        {
            this.userSurveysDal = userSurveysDal;
            this.yesNoAnswerDal = yesNoAnswerDal;

        }

        public void Add(UserPoll userPoll)
        {
            userSurveysDal.Add(userPoll);
        }

        public bool CheckVotedUser(int userId, int pollId)
        {
            return userSurveysDal.CheckVotedUser(userId , pollId);
        }

        public List<UserPoll> MissedPollsOfUser(int ıd)
        {
            return userSurveysDal.GetMissedPollsOfUserByUserId(ıd);
        }

        public void Voted(PollDTO polDTO, User user)
        {
            YesNoAnswer answer = new YesNoAnswer();
            answer = polDTO.YesNoAnswer;
            answer.YesNoQuestionId = polDTO.YesNoQuestion.Id;
            yesNoAnswerDal.AddYesNoAnswer(answer);
            UserPoll userPoll = new UserPoll();
            userPoll.PollId = polDTO.Poll.Id;
            userPoll.UserId = user.Id;
            userSurveysDal.Add(userPoll);
        }

        public List<UserPoll> VotedPollsOfUser(int ıd)
        {
            return userSurveysDal.GetVotedPollsOfUserByUserId(ıd);
        }

        List<UserPoll> IUserSurveysService.VotedPollsOfUser(int ıd)
        {
            return userSurveysDal.GetVotedPollsOfUserByUserId(ıd);
        
        }
    }
}
