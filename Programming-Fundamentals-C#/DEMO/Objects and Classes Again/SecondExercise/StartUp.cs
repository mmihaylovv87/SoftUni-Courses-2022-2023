using System;

namespace SecondExercise
{

    public class StartUp
    {
        public static void Main()
        {
            string[] articles = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int commandCount = int.Parse(Console.ReadLine());

            string title = articles[0];
            string content = articles[1];
            string author = articles[2];
            Article article = new Article(title, content, author);

            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string action = command[0];
                string newArticle = command[1];

                if (action == "Edit")
                    article.Edit(newArticle);
                else if (action == "ChangeAuthor")
                    article.ChangeAuthor(newArticle);
                else if (action == "Rename")
                    article.Rename(newArticle);
            }
            Console.WriteLine(article);
        }
    }
}