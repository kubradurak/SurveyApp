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
        List<UserPoll> GetMissedPollsOfUserByUserId(int ıd);
        List<UserPoll> GetVotedPollsOfUserByUserId(int ıd);
        List<Poll> GEtPollByUserıd(int ıd);
    }
}
