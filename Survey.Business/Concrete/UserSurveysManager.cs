using Survey.Business.Abstract;
using Survey.DataAccess.Abstract;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Concrete
{
    public class UserSurveysManager : IUserSurveysService
    {
        private IUserSurveysDal userSurveysDal;

        public UserSurveysManager(IUserSurveysDal userSurveysDal)
        {
            this.userSurveysDal = userSurveysDal;

        }

        public void Add(UserPoll userPoll)
        {
            userSurveysDal.Add(userPoll);
        }

        public bool CheckVotedUser(int userId, int pollId)
        {
            return userSurveysDal.CheckVotedUser(userId , pollId);
        }
    }
}
