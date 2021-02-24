using Survey.Business.Abstract;
using Survey.DataAccess.Abstract;
using Survey.Entities;
using Survey.Entities.DTO;
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
       

        public void AddQuestion(QuestionDTO questionDTO)
        {
            YesNoQuestion question = new YesNoQuestion();
            question = questionDTO.YesNoQuestion;
            question.Id = questionDTO.YesNoQuestion.Id;
            question.PollId = questionDTO.Poll.Id;
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
