using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Entities.DTO
{
    public class QuestionDTO
    {
        public Poll Poll { get; set; }
        public YesNoQuestion YesNoQuestion { get; set; }
    }
}
