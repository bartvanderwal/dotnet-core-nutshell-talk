using System;

// TODO: Naar andere namespace verhuizen.
namespace talks.Controllers
{
    public class Talk
    {
        private string title;
        private string talker;
        public int Id { get; }
        public string Title { get { return title; } set { title = value; }}
        public string Talker { get { return talker; } set { talker = value; } }
        public DateTime ScheduledAt { get; set; }

        public Talk(int id, string titel, string talker, DateTime scheduledAt)
        {
            this.Id = id;
            this.title = titel;
            this.talker = talker;
            ScheduledAt = scheduledAt;
        }
    }
}