using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.DataAccess.Abstract
{
    public interface IYesNoAnswerDal
    {
        void AddYesNoAnswer(YesNoAnswer answer);
        List<YesNoAnswer> GetAnswers();
        int GetAnswersByQuestionId(int id);
        List<YesNoAnswer> GetAnswersById(int ıd);
    }
}