using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Abstract
{
    public interface IPollService
    {
        List<Poll> GetPolls(int id);
        List<Poll> GetPolls();
        void AddPoll(Poll poll);
        Poll GetPollsForDetails(int id);
        void  Update(Poll poll);
        void Delete(Poll poll);
        Poll GetPollById(int id);
        List<Poll> HaventQuestionPoll();
        List<Poll> GetExpiredPolls();
        List<Poll> GetActivePolls();
        int GetPollByQuestionId(int a);
        void FileDowloadFormatWordById(int id);
        void SendMail(int id);
        bool IsApprovedPoll(int pollId, int questionId);
        List<Poll> GetApprovedPolls();
        List<Poll> GetUnapprovedPolls();
    }
}
