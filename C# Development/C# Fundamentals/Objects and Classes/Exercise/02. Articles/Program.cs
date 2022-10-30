using System;
using System.Reflection.Metadata.Ecma335;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(", ");
            Article article = new Article(commands[0], commands[1], commands[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] newCommands = Console.ReadLine().Split(": ");
                switch (newCommands[0])
                {
                    case "Edit":
                        article.Edit(newCommands[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(newCommands[1]);
                        break;
                    case "Rename":
                        article.Rename(newCommands[1]);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title=title;
            this.Content=content;
            this.Author=author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content) => this.Content=content;
        public void ChangeAuthor(string author) => this.Author=author;
        public void Rename(string title) => this.Title=title;

        public override string ToString() => $"{this.Title} - {this.Content}: {this.Author}";

    }
}
