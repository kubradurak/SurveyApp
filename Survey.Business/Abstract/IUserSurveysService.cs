using Survey.Entities;
using Survey.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Abstract
{
    public interface IUserSurveysService
    {
        bool CheckVotedUser(int userId, int pollId);
        void Add(UserPoll userPoll);
        List<UserPoll> MissedPollsOfUser(int ıd);
        List<UserPoll> VotedPollsOfUser(int ıd);
        void Voted(PollDTO polDTO, User user);
    }
}
