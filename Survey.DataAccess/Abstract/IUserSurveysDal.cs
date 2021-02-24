using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.DataAccess.Abstract
{
    public interface IUserSurveysDal
    {
        bool CheckVotedUser(int userId, int pollId);
        void Add(UserPoll userPoll);
    }
}
