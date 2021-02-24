using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Survey.Entities
{
    public class Poll
    {
        public int Id { get; set; }
        [Display(Name = "Anket başlığı")]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Son geçerlilik günü")]
        public DateTime CheckinDate { get; set; }
        [Display(Name = "Gerekli oy sayısı")]
        public int RequiredVote { get; set; }
        [Display(Name = "Evet/Hayır Soruları")]
        public IList<YesNoQuestion> YesNoQuestions { get; set; } // 
        public IList<UserPoll> UserPolls { get; set; }

        public double HowManyDays()
        {
            return (CheckinDate - DateTime.Today).TotalDays;
        }
    }
}
