using Microsoft.EntityFrameworkCore;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.DataAccess.Concrete.EfCore.Data
{
    public class TurkcellPollDbContext:DbContext
    {
        public TurkcellPollDbContext(DbContextOptions<TurkcellPollDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; } // 
        public DbSet<Poll> Surveys { get; set; }
        public DbSet<YesNoQuestion> YesNoQuestions { get; set; }
        public DbSet<YesNoAnswer> YesNoAnswers { get; set; }
        public DbSet<UserPoll> UserSurveys { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YesNoAnswer>()
                .HasOne(x => x.YesNoQuestion)
                .WithMany(y => y.YesNoAnswers)
                .HasForeignKey(fk => fk.YesNoQuestionId);

            modelBuilder.Entity<YesNoQuestion>()
                .HasOne(a => a.Poll)
                .WithMany(b => b.YesNoQuestions)
                .HasForeignKey(fk => fk.PollId);

            modelBuilder.Entity<UserPoll>()
                .HasKey(fk => new { fk.UserId, fk.PollId });

            modelBuilder.Entity<UserPoll>()
                .HasOne(x => x.Poll)
                .WithMany(y => y.UserPolls)
                .HasForeignKey(fk => fk.PollId);

            modelBuilder.Entity<UserPoll>()
                .HasOne(e => e.User)
                .WithMany(d => d.UserPolls)
                .HasForeignKey(c => c.UserId);



            base.OnModelCreating(modelBuilder);
        }

        
    }
}