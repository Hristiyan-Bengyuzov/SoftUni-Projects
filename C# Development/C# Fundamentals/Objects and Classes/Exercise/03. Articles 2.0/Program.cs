using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int articlesCount = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < articlesCount; i++)
            {
                string[] commands = Console.ReadLine().Split(", ");
                Article article = new Article(commands[0], commands[1], commands[2]);
                articles.Add(article);
            }

            string message = Console.ReadLine();
            articles.ForEach(article=>Console.WriteLine(article));
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString() => $"{this.Title} - {this.Content}: {this.Author}";

    }
}
