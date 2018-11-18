using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace talks.Controllers
{

    public class TalksService
    {

        private IList<Talk> talks;

        private Dictionary<string, Talk> talksCache = new Dictionary<string, Talk>();

        public TalksService() {
                        talks = new List<Talk> {
                new Talk(1, "Kotlin", "Avisi", new DateTime(2018, 11, 14, 12, 30, 0)),
                new Talk(2, ".NET Core", "Bart", new DateTime(2018, 11, 19, 13, 00, 0)),
                new Talk(3, "Ionic", "Bart", new DateTime(2018, 11, 21).Date)
            };

            // Vul de laatste 2 items in de cache.
            fillCacheWithTalks(talks);

        }
        public IEnumerable<Talk> Get()
        {
            return talks.ToList();
        }

        public Talk Get(string title)
        {
            Console.WriteLine($"id: {title}");
            if (talksCache.ContainsKey(title)) {
                return talksCache[title];
            } else {
                return (from t in talks where t.Title==title select t).FirstOrDefault();
            }
        }

        public void Post(string title)
        {
            var talk = createTalkFromTitle(title);
            talks.Add(talk);
            addTalkToCache(talk);
        }

        public void Put(int id, [FromBody] string title)
        {
            title = title.Replace('-', ' ').Replace('+', ' ');
            talks[id] = createTalkFromTitle(title);
        }

        public void Delete(int id)
        {
            try {
                talks.RemoveAt(id);
                fillCacheWithTalks(talks);
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e);
                return;
            }
        }

        /**
         * Fill the cache.
         */
        private void fillCacheWithTalks(IEnumerable<Talk> talks)
        {
            const int maxCacheSize = 2;
            var aboveMax = talks.Count()-maxCacheSize;
            if (aboveMax>0) {
                talks = talks.Skip(aboveMax).Take(maxCacheSize);
            }
            // foreach(var talk in talks) {
            //     addTalkToCache(talk);
            // }
            talks.ForEach(talk => addTalkToCache(talk));
        }

        private void addTalkToCache(Talk talk)
        {
            if (talksCache.ContainsKey(talk.Title)) {
                throw new NonUniqueTitleException();
            }
            talksCache[talk.Title] = talk;
        }
        
        private Talk createTalkFromTitle(string title) {
            var newId = (from t in talks select t.Id).Max();
            return new Talk(newId, title, "Uwe", new DateTime());
        }
    }
}
