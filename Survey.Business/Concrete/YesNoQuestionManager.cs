using Survey.Business.Abstract;
using Survey.DataAccess.Abstract;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Concrete
{
    public class YesNoQuestionManager : IYesNoQuestionService
    {
        private IYesNoQuestionDal yesNoQuestionDal;

        public YesNoQuestionManager(IYesNoQuestionDal yesNoQuestionDal)
        {
            this.yesNoQuestionDal = yesNoQuestionDal;
        }
        public void AddQuestion(YesNoQuestion question)
        {
            yesNoQuestionDal.Add(question);
        }

        public object DeleteQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public object GetQuestionById(int id)
        {
            throw new NotImplementedException();
        }


        public List<YesNoQuestion> GetQuestions()
        {
          return  yesNoQuestionDal.GetQuestions();
        }

        public List<YesNoQuestion> GetQuestionsByPollId(int id)
        {
            return yesNoQuestionDal.GetQuestionsByPollId(id);
        }

        public void UpdateQuestion(YesNoQuestion yesNoQuestion)
        {
            throw new NotImplementedException();
        }

       
    }
}
