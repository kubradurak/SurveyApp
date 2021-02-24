using Survey.DataAccess.Abstract;
using Survey.DataAccess.Concrete.EfCore.Data;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survey.DataAccess.Concrete.EfCore
{
    public class EfCoreUserSurveysDal : IUserSurveysDal
    {
        private TurkcellPollDbContext dbContext;

        public EfCoreUserSurveysDal(TurkcellPollDbContext turkcellPollContext)
        {
            this.dbContext = turkcellPollContext;
        }

        public void Add(UserPoll userPoll)
        {
            dbContext.Add(userPoll);
            dbContext.SaveChanges();

        }

        public bool CheckVotedUser(int userId, int pollId)
        {
            return dbContext.UserSurveys.Any(c => c.UserId == userId && c.PollId == pollId);
        }

    }
}
