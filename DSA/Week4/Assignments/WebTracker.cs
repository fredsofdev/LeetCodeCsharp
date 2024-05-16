using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4.Assignments
{
    internal class WebTracker
    {
        private readonly Dictionary<string, Dictionary<string, int>> visits = new();

        public void Visit(string user, string website)
        {
            if(visits.ContainsKey(user))
            {
                visits[user].Add(website, visits[user].GetValueOrDefault(website) + 1);
            }
            else
            {
                visits.Add(user, new() {[website] = 1});
            }
        }

        public int GetVisits(string user, string website)
        {
            if (!visits.TryGetValue(user, out Dictionary<string, int> visit)) return 0;
            if (visit.ContainsKey(website)) return visit[website];
            return 0;
        }
    }
}
