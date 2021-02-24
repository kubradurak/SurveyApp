using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.WebUI.Models
{
    public class SurveyDTO 
    {
        public int PollId { get; set; }
        public string PollTitle { get; set; }
        public string PollDesc { get; set; }

        //public List<QuestionDTO> questionDTOs;
        public bool IsAccepted { get; set; }
        public string UserComment { get; set; } = string.Empty;
        public int YesNoQuestionId { get; set; }
        public string Question { get; set; }
    }
  
}
