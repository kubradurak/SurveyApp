using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Survey.Entities
{
    public class YesNoQuestion : Question
    {
        [Display(Name = "Evet/Hayır Cevapları")]
        public virtual IList<YesNoAnswer> YesNoAnswers { get; set; }
    }
}