using Microsoft.EntityFrameworkCore;
using Survey.DataAccess.Abstract;
using Survey.DataAccess.Concrete.EfCore.Data;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Survey.DataAccess.Concrete.EfCore
{
    public class EfCorePollDal : IPollDal
    {
        private TurkcellPollDbContext dbContext;

        public EfCorePollDal(TurkcellPollDbContext turkcellPollDbContext)
        {
            this.dbContext = turkcellPollDbContext;
        }
        public void Create(Poll poll)
        {
            dbContext.Add(poll);
            dbContext.SaveChanges();
        }

        public void Delete(Poll poll)
        {
            dbContext.Surveys.Remove(poll);
            dbContext.SaveChanges();
        }

        public IQueryable<Poll> GetAll(Expression<Func<Poll, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Poll GetById(int id)
        {
            var poll = dbContext.Surveys.Find(id);
            return poll;
        }
        public List<Poll> GetAll()
        {
            return dbContext.Surveys.ToList();

        }

        public Poll GetOne(Expression<Func<Poll, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Poll poll)
        {
            dbContext.Entry(poll).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public Poll GetByIdWithDetails(int id)
        {
            var survey = dbContext.Surveys.Include(x => x.YesNoQuestions)
                           .Include(a => a.UserPolls)
                           .FirstOrDefault(a => a.Id == id);
            return survey;
        }

        public int GetPollByQuestionId(int id)
        {
            foreach (var item in dbContext.YesNoQuestions)
            {
                if (item.PollId == id )
                {
                    return item.PollId;
                }
            }
            return -1;
        }
    }
}
