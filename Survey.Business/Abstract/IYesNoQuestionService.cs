using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Abstract
{
    public interface IYesNoQuestionService
    {
        List<YesNoQuestion> GetQuestions();
        void AddQuestion(YesNoQuestion question);
        object GetQuestionById(int id);
        void UpdateQuestion(YesNoQuestion yesNoQuestion);
        object DeleteQuestion(int id);
        List<YesNoQuestion> GetQuestionsByPollId(int id);
    }
}