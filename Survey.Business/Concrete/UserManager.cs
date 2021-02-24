using Survey.Business.Abstract;
using Survey.DataAccess.Abstract;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal userDal;

        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }
        public void AddUser(User registerUser)
        {
            userDal.Add(registerUser);
        }

        public bool CheckUser(User registerUser)
        {
            return userDal.CheckUser(registerUser);
        }

        public List<Poll> GetPollsOfToBeVotedUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserName(string userName)
        {

            return userDal.GetUserByUserName(userName);
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User ValidUser(string username, string password)
        {
            var user = userDal.ValidUser(username, password);
            return user;

        }
    }
}
