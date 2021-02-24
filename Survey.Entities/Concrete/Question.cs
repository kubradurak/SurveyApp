using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Survey.Entities
{
    public class Question
    {
        public int Id { get; set; }
        [Display(Name = "Soru içeriği")]
        public string Content { get; set; }

        public int PollId { get; set; }
        public Poll Poll { get; set; }
    }
}
