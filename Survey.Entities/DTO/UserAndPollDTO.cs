using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Entities.DTO
{
    public class UserAndPollDTO
    {
        public User User { get; set; }
        public List<Poll> Polls { get; set; }
    }
}
