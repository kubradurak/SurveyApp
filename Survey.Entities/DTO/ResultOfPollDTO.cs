using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Entities.DTO
{
    public class ResultOfPollDTO
    {
        public Poll Poll { get; set; }
        public List<YesNoAnswer> YesNoAnswers { get; set; }

        public int Approvers { get; set; }
        public int Rejecting { get; set; }
    }
}
