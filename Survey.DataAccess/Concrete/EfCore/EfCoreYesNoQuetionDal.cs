using Microsoft.EntityFrameworkCore;
using Survey.DataAccess.Abstract;
using Survey.DataAccess.Concrete.EfCore.Data;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survey.DataAccess.Concrete.EfCore
{
    public class EfCoreYesNoQuetionDal : IYesNoQuestionDal
    {
        private TurkcellPollDbContext dbContext;

        public EfCoreYesNoQuetionDal(TurkcellPollDbContext pollDbContext)
        {
            this.dbContext = pollDbContext;
        }
        public void Add(YesNoQuestion question)
        {
            dbContext.Add(question);
            dbContext.SaveChanges();
        }

        public object Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<YesNoAnswer> GetAnswersByQuestionId(int ıd)
        {
            return dbContext.YesNoAnswers.Where(x => x.Id == ıd).ToList();
        }

        public object GetQuestionById(int id)
        {
            throw new NotImplementedException();
        }

        public object GetQuestionByIdWithPoll(int id)
        {
            throw new NotImplementedException();
        }

        public List<YesNoQuestion> GetQuestions()
        {
            return dbContext.YesNoQuestions.Include(x => x.Poll).AsNoTracking().ToList();
        }

        public List<YesNoQuestion> GetQuestionsByPollId(int id)
        {
            var questions = dbContext.YesNoQuestions.AsNoTracking().Where(x => x.PollId == id).ToList();
            return questions;
        }

        public void Update(YesNoQuestion yesNoQuestion)
        {
            throw new NotImplementedException();
        }
    }
}
