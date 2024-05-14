using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_14._05
{
    internal class Program
    {
        static void Main()
        {
            DateTime createdAt = DateTime.Now;
            Journal journal1 = new Journal(1, "Journal", "Name1", createdAt, 144);
            journal1.AddArticle(new Article("Name1", 144, DateTime.Now));
            journal1.AddArticle(new Article("Name2", 1435, DateTime.Now));
            Console.WriteLine(journal1);
            string json = ParseToJSON<Journal>.ConvertToJson(journal1);
            Console.WriteLine(json);
            Console.WriteLine(ParseToJSON<Journal>.ConvertFromJson(json));
            //JsonFile<Journal>.WriteJsonFile(journal1, "info.txt");
            var res = JsonFile<Journal>.ReadOneObject("info.txt");
            Console.WriteLine(res);

            Journal journal2 = new Journal(2, "Journal1", "NewName", createdAt, 1243);
            journal2.AddArticle(new Article("Name2", 1214, DateTime.Now));
            journal2.AddArticle(new Article("Name4", 1435, DateTime.Now));
            List<Journal> list = new List<Journal>
            {
                journal1,
                journal2
            };
            

            JournalStorage journalStorage = new JournalStorage();
            journalStorage.AddJournal(journal1);
            journalStorage.AddJournal(journal2);

            JsonFile<Journal>.WriteJsonFile(journalStorage.Journals, "listObj.txt");
            JournalStorage storage =  new JournalStorage(JsonFile<Journal>.ReadObjectList("listObj.txt"));
            Console.WriteLine(storage);
        }
    }
}
