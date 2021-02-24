using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Entities
{
    public class UserPoll
    {
        public int PollId { get; set; }
        public Poll Poll { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
