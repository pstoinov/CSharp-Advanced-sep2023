using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            Console.WriteLine(string.Join("\n", articles));

        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
                ArticlesList = new List<string>();
            }

            private string Title { get; set; }
            private string Content { get; set; }
            private string Author { get; set; }
            private List<string> ArticlesList { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}"; ;
            }
        }
    }
}
