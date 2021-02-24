using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Business.Abstract
{
    public interface IUserService
    {
        User ValidUser(string username, string password);
        bool CheckUser(User registerUser);
        void AddUser(User registerUser);
        List<Poll> GetPollsOfToBeVotedUser();
        List<User> GetUsers();
        User GetUserById(int id);
        void UpdateUser(User user);
        User GetUserByUserName(string userName);
    }
}
