using System.Collections.Generic;

namespace talks
{
    public interface ITalksService
    {
        IEnumerable<Talk> Get();

        Talk Get(string title);

        void Post(string title);

        void Put(int id, string title);

        void Delete(int id);

    }
}