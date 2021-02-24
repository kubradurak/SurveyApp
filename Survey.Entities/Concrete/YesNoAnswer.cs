using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Survey.Entities
{
    public class YesNoAnswer : Answer
    {

        public bool IsAccepted { get; set; }
        [Display(Name = "Eklemek istediğiniz bir şey var mı?")]
        public string UserComment { get; set; }
        public int YesNoQuestionId { get; set; }
        public YesNoQuestion YesNoQuestion { get; set; }
    }
}