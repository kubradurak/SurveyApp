using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Entities.DTO
{
    public class PollDTO
    {
        public Poll Poll  { get; set; }
        public YesNoQuestion YesNoQuestion { get; set; }
        public YesNoAnswer YesNoAnswer { get; set; }
    }
}
