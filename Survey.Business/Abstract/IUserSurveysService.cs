using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Abstract
{
    public interface IUserSurveysService
    {
        bool CheckVotedUser(int userId, int pollId);
        void Add(UserPoll userPoll);
    }
}
