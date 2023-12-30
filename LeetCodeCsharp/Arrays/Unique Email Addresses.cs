using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Unique_Email_Addresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> forward = new();
            foreach (string email in emails)
            {
                var emailParts = email.Split('@');
                string local = emailParts[0];
                string domain = emailParts[1];

                local = local.Split('+')[0].Replace(".","");
                forward.Add(local+"@"+domain);
            }
            return forward.Count;
        }
    }
}
