using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_14._05
{
    internal class JournalStorage
    {
        public int JournalsNumber { get; set; }
        public List<Journal> Journals { get; set; }
        public JournalStorage()
        {
            JournalsNumber = 0;
            Journals = new List<Journal>();
        }
        public JournalStorage(List<Journal> journals)
        {
            Journals = journals;
            JournalsNumber = journals.Count;
        }

        public void AddJournal(Journal journal)
        {
            Journals.Add(journal);
            JournalsNumber++;
        }
        public override string ToString()
        {
            string res = "";
            foreach (Journal journal in Journals)
            {
                res += journal.ToString() + "\n";
            }
            return res;
        }
    }
}
