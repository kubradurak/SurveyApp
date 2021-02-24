using Survey.Business.Abstract;
using Survey.DataAccess.Abstract;
using Survey.DataAccess.Concrete.EfCore;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Survey.Business.Concrete
{
    public class PollManager : IPollService
    {
        private IPollDal pollDal;
        private IYesNoQuestionDal yesNoQuestionDal;
        private IUserDal userDal;
        private IYesNoAnswerDal yesNoAnswerDal;

        public PollManager(IPollDal pollDal,
            IYesNoAnswerDal yesNoAnswerDal,
            IYesNoQuestionDal yesNoQuestionDal, IUserDal userDal)
        {
            this.pollDal = pollDal;
            this.yesNoQuestionDal = yesNoQuestionDal;
            this.userDal = userDal;
            this.yesNoAnswerDal = yesNoAnswerDal;
        }

        public void AddPoll(Poll poll)
        {
            pollDal.Create(poll);
        }

        public void Delete(Poll poll)
        {
            pollDal.Delete(poll);     
        }

        public void FileDowloadFormatWordById(int id)
        {
            // dosyayı indir.
            var poll = pollDal.GetByIdWithDetails(id);
            // 
            //
            //
            //
            //


        }

        public List<Poll> GetActivePolls()
        {
           return pollDal.GetAll();
        }

        public List<Poll> GetExpiredPolls()
        {
            return pollDal.GetAll();
        }

        public Poll GetPollById(int id)
        {
            return pollDal.GetById(id);
        }

        public int GetPollByQuestionId(int a)
        {
            return pollDal.GetPollByQuestionId(a);
                }

        public List<Poll> GetPolls(int id)
        {
           return pollDal.GetAll();// minik bir mantık hatası var
        }

        public List<Poll> GetPolls()
        {
            return pollDal.GetAll();

        }

        public Poll GetPollsForDetails(int id)
        {
            return pollDal.GetByIdWithDetails(id);

        }

        public List<Poll> HaventQuestionPoll()
        {
            return pollDal.GetAll();// sorusu olmayanlar
        }

        public bool IsApprovedPoll(int pollId, int questionId)
        {
            int requiredValue = pollDal.GetById(pollId).RequiredVote;
            var apprevedValue = yesNoAnswerDal.GetAnswersByQuestionId(questionId);
            if (requiredValue >= apprevedValue)
            {
                SendMail(pollId);
                return true;
            }
            return false;
        }

        public void SendMail(int id)
        {
            var adminList = userDal.GetAdmins();
            var poll = pollDal.GetById(id);
                foreach (var admin in adminList)
                    {
                        var title = poll.Title;
                        var decs = poll.Description;

                        MailMessage mail = new MailMessage();

                        mail.To.Add(admin.Email);
                        mail.From = new MailAddress("infoturkcellFinalProject@gmail.com");
                        mail.Subject = "Onaylanan bir anket var!";
                        mail.Body = $"Sayın yetki <br> {title} başlıklı anket kullanıcılar tarafından yeter ki onayı aldı";
                        mail.IsBodyHtml = true;


                        SmtpClient smtp = new SmtpClient();
                        smtp.Credentials = new NetworkCredential("infoturkcellFinalProject@gmail.com", "turkcell.net");
                        smtp.Port = 587;
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        smtp.Send(mail);                 
            }
           
        }

        public void Update(Poll poll)
        {
            pollDal.Update(poll);
        }
    }
}
