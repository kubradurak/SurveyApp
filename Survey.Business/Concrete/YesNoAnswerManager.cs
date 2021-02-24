using Survey.Business.Abstract;
using Survey.DataAccess.Abstract;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Concrete
{
    public class YesNoAnswerManager : IYesNoAnswerService
    {
        private IYesNoAnswerDal yesNoAnswerDal;

        public YesNoAnswerManager(IYesNoAnswerDal yesNoAnswerDal)
        {
            this.yesNoAnswerDal = yesNoAnswerDal;
        }
        public void AddYesNoAnswer(YesNoAnswer answer)
        {
            yesNoAnswerDal.AddYesNoAnswer(answer);
        }

        public List<YesNoAnswer> GetAnswers()
        {
            return yesNoAnswerDal.GetAnswers();
                }
    }
}
