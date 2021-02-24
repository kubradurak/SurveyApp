using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Survey.Entities;

namespace Survey.DataAccess.Abstract
{
    public interface IPollDal
    {
        Poll GetById(int id);
        Poll GetOne(Expression<Func<Poll, bool>> filter);
        List<Poll> GetAll();
        List<YesNoQuestion> GetQuestionsByPollID(int id);
        void Update(Poll poll);
        void Delete(Poll poll);
        void Create(Poll poll);

        Poll GetByIdWithDetails(int id);
        int GetPollByQuestionId(int a);
        List<Poll> GetApprovedPoll();
        YesNoQuestion GetQuestionsByPollIdForVote(int id);
    }
}
