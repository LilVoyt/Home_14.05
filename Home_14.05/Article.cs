using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_14._05
{
    internal class Article
    {
        public string Name { get; set; }
        public int SymbolsNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public Article() { }
        public Article(string Name, int PagesNumber, DateTime CreatedAt)
        {
            this.Name = Name;
            this.SymbolsNumber = PagesNumber;
            this.CreatedAt = CreatedAt;
        }
        public override string ToString()
        {
            return $"Name: {Name}, SymbolsNumber: {SymbolsNumber}, CreatedAt: {CreatedAt} ";
        }
    }
}
