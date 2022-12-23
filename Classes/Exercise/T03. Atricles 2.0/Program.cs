using System;
using System.Collections.Generic;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Article newArticles = new Article();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article newArticle = new Article(title, content, author);
                newArticles.Collection.Add(newArticle);
            }

            foreach (var item in newArticles.Collection)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
            }
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;

        }

        public Article()
        {
            this.Collection = new List<Article>();
        }

        public List<Article> Collection { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}