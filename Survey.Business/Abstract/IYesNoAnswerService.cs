using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Abstract
{
    public interface IYesNoAnswerService
    {
        void AddYesNoAnswer(YesNoAnswer answer);
        List<YesNoAnswer> GetAnswers();

    }
}