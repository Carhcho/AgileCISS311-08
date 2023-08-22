using System;
using System.Collections.Generic;

namespace dropbox08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int numberOfFruitEaten = 0;
            List<int> xPosition = new List<int>();
            List<int> yPosition = new List<int>();
            xPosition.Add(25);
            yPosition.Add(20);
            Snake snake = new Snake(xPosition, yPosition, numberOfFruitEaten);
            Console.SetCursorPosition(snake.Xposition[0], snake.Yposition[0]);
            Console.WriteLine(((char)214).ToString());
            bool isEaten = false;
            Fruit fruit = new Fruit();
            Console.WriteLine(fruit);
            ConsoleKey playerKey = Console.ReadKey().Key;
            do
            {
                Console.SetCursorPosition(snake.Xposition[numberOfFruitEaten], snake.Yposition[numberOfFruitEaten]);
                Console.Write(" ");
                if (snake.Xposition[0] == fruit.Xposition && snake.Yposition[0] == fruit.Yposition)
                    isEaten = true;
                if (isEaten)
                {
                    Console.WriteLine(fruit);
                    isEaten = false;
                    numberOfFruitEaten++;
                    snake.Xposition.Add(snake.Xposition[0]);
                    snake.Yposition.Add(snake.Yposition[0]);
                }
                List<int> xold = snake.Xposition;
                List<int> yold = snake.Yposition;
                snake.NumberOfFruitEaten = numberOfFruitEaten;
                
                for (int j = numberOfFruitEaten; j > 0; j--)
                {
                    xold[j] = xold[j - 1];
                    yold[j] = yold[j - 1];
                }
                if (playerKey == ConsoleKey.LeftArrow)
                    snake.MoveLeft();
                else if (playerKey == ConsoleKey.RightArrow)
                    snake.MoveRight();
                else if (playerKey == ConsoleKey.UpArrow)
                    snake.MoveUp();
                else if (playerKey == ConsoleKey.DownArrow)
                    snake.MoveDown();

                Console.Write(snake);
                snake.Xposition = xold;
                snake.Yposition = yold;
                if (Console.KeyAvailable)
                    playerKey = Console.ReadKey().Key;
                System.Threading.Thread.Sleep(240);
            } while (playerKey == ConsoleKey.LeftArrow || playerKey == ConsoleKey.RightArrow || playerKey == ConsoleKey.UpArrow || playerKey == ConsoleKey.DownArrow);
            Console.ReadKey();
        }
    }
}
