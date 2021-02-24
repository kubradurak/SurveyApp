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
    public class EfCoreYesNoAnswerDAl : IYesNoAnswerDal
    {
        private TurkcellPollDbContext dbContext;

        public EfCoreYesNoAnswerDAl(TurkcellPollDbContext turkcellPollDbContext)
        {
            this.dbContext = turkcellPollDbContext;

        }
        public void AddYesNoAnswer(YesNoAnswer answer)
        {
            dbContext.Add(answer);
            dbContext.SaveChanges();
        }

        public List<YesNoAnswer> GetAnswers()
        {
            return dbContext.YesNoAnswers.Include(x => x.YesNoQuestion).AsNoTracking().ToList();
        }
    }
}
