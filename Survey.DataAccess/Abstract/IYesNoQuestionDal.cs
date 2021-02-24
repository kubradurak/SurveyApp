using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.DataAccess.Abstract
{
    public interface IYesNoQuestionDal
    {
        List<YesNoQuestion> GetQuestions();

        void Add(YesNoQuestion question);
        List<YesNoQuestion> GetQuestionsByPollId(int id);
        object GetQuestionById(int id);
        object GetQuestionByIdWithPoll(int id);
        void Update(YesNoQuestion yesNoQuestion);
        object Delete(int id);
        List<YesNoAnswer> GetAnswersByQuestionId(int ıd);
    }
}