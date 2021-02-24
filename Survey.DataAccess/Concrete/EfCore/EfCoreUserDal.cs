using Survey.DataAccess.Abstract;
using Survey.DataAccess.Concrete.EfCore.Data;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survey.DataAccess.Concrete.EfCore
{
    public class EfCoreUserDal : IUserDal
    {
        private TurkcellPollDbContext dbContext;

        public EfCoreUserDal(TurkcellPollDbContext SurveyDbContext)
        {
            this.dbContext = SurveyDbContext;

        }
        public void Add(User registerUser)
        {
            dbContext.Users.Add(registerUser);
            dbContext.SaveChanges();
        }

        public bool CheckUser(User registerUser)
        {
            bool IsSavedUser = false;
            foreach (var c in dbContext.Users)
            {
                if (c.UserName.ToLower() == registerUser.UserName.ToLower())
                {
                    IsSavedUser = true;
                }
            }
            return IsSavedUser;
        }

        public List<Poll> GetPollOfToBeVotedUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserName(string userName)
        {
            return dbContext.Users.FirstOrDefault(x => x.UserName == userName);
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public User ValidUser(string username, string password)
        {
            return dbContext.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            //throw new NotImplementedException();

        }
    }
}
