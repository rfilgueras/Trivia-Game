using static System.Console;

namespace TriviaGame1
{
    public class Game
    {
        string gameName = "Trivia Tuesdays";

        public Game()
        {
            Title = gameName;
            WriteLine($"Welcome to {gameName}");

            Start();

        }

        public static void Start()
        {
            string Name = "Jane Doe";
            WriteLine("What is your name?");
            Name = ReadLine();
            WriteLine($"Hello {Name}! Let's start playing Trivia Tuesdays!\n");
            WriteLine("Press enter to continue");
            ReadLine();

            TriviaItem item1 = new TriviaItem();
            item1.Topic = "Atoms\n";
            item1.Question = "1. When was the idea of the atom first introduced?";
            item1.Choices = "A) 400 B.C\nB) 545 B.C.\nC) 450 B.C.\n";
            string CorrectAnswer = "C";

            WriteLine(item1.Topic);
            WriteLine(item1.Question);
            WriteLine(item1.Choices);
            WriteLine("Please type the letter for your answer: \n");
            CorrectAnswer = ReadLine();


            if (CorrectAnswer == "c")
            {
                WriteLine("That is correct!");
            }
            else if (ReadLine() != "C")
            {
                WriteLine("Sorry! The correct answer is C");
            }
            WriteLine("Press enter for the next question");
            ReadLine();


            TriviaItem item2 = new TriviaItem();
            item2.Topic = "Topic: Astronomers\n";
            item2.Question = "2.Which astronomer first discovered the sunspots on the sun?";
            item2.Choices = "A) Johannes Kepler\nB) Galileo Galilei\nC) Nicolaus Copernicus\n";
            string CorrectAnswer2 = "B";

            WriteLine(item2.Topic);
            WriteLine(item2.Question);
            WriteLine(item2.Choices);
            WriteLine("Please type the letter for your answer: \n");
            CorrectAnswer2 = ReadLine();


            if (CorrectAnswer2 == "b")
            {
                WriteLine("That is correct!");
            }
            else if (ReadLine() != "B")
            {
                WriteLine("Sorry! The correct answer is B");
            }
            WriteLine("Thanks for Playing!");
            ReadLine();
        }

    }
}
