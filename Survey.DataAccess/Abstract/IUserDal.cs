using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.DataAccess.Abstract
{
    public interface IUserDal
    {
        User ValidUser(string username, string password);
        bool CheckUser(User registerUser);
        void Add(User registerUser);
        List<Poll> GetPollOfToBeVotedUser();
        List<User> GetUsers();
        User GetUserById(int id);
        void Update(User user);
        User GetUserByUserName(string userName);
    }
}

