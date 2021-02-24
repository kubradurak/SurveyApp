using Survey.Business.Abstract;
using Survey.DataAccess.Abstract;
using Survey.DataAccess.Concrete.EfCore;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Concrete
{
    public class PollManager : IPollService
    {
        private IPollDal pollDal;

        public PollManager(IPollDal pollDal)
        {
            this.pollDal = pollDal;
        }

        public void AddPoll(Poll poll)
        {
            pollDal.Create(poll);
        }

        public void Delete(Poll poll)
        {
            pollDal.Delete(poll);     
        }

        public List<Poll> GetActivePolls()
        {
           return pollDal.GetAll();
        }

        public List<Poll> GetExpiredPolls()
        {
            return pollDal.GetAll();
        }

        public Poll GetPollById(int id)
        {
            return pollDal.GetById(id);
        }

        public int GetPollByQuestionId(int a)
        {
            return pollDal.GetPollByQuestionId(a);
                }

        public List<Poll> GetPolls(int id)
        {
           return pollDal.GetAll();// minik bir mantık hatası var
        }

        public List<Poll> GetPolls()
        {
            return pollDal.GetAll();

        }

        public Poll GetPollsForDetails(int id)
        {
            return pollDal.GetByIdWithDetails(id);

        }

        public List<Poll> HaventQuestionPoll()
        {
            return pollDal.GetAll();// sorusu olmayanlar
        }

        public void Update(Poll poll)
        {
            pollDal.Update(poll);
        }
    }
}
