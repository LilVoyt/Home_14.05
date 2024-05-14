using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_14._05
{
    internal class Journal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PublisherName { get; set; }
        public DateTime Date { get; set; }
        public int PagesNumber { get; set; }
        public List<Article> Articles { get; set; }

        public Journal(int id, string name, string publisherName, DateTime date, int pagesNumber)
        {
            Id = id;
            Name = name;
            PublisherName = publisherName;
            Date = date;
            PagesNumber = pagesNumber;
            Articles = new List<Article>();
        }
        public void AddArticle(Article article)
        {
            this.Articles.Add(article);
        }

        public override string ToString()
        {
            string res = "\n";
            foreach (var item in Articles)
            {
                res += item.ToString() + "\n";
            }
            return $"Article Id: {Id}, Name: {Name}, PublisherName: {PublisherName}, Date: {Date}, " +
                $"PagesNumber: {PagesNumber}, Articles: {res}";
        } 
    }
}
