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

        public List<User> GetAdmins()
        {
            return dbContext.Users.Where(a => a.Role == Role.Admin).ToList();
        }

        public List<Poll> GetPollOfToBeVotedUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            return dbContext.Users.Find(id);
        }

        public User GetUserByUserName(string userName)
        {
            return dbContext.Users.FirstOrDefault(x => x.UserName == userName);
        }

        public List<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }

        public void Update(User user)
        {
            dbContext.Entry(user).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public User ValidUser(string username, string password)
        {
            return dbContext.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

        }
    }
}
