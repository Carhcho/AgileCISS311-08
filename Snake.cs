using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox08
{
    class Snake
    {
        //private int xPosition;
        //private int yPosition;
        private List<int> xPosition;
        private List<int> yPosition;
        private int numberOfFruitEaten;

        public List<int> Xposition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public List<int> Yposition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public int NumberOfFruitEaten
        {
            get { return numberOfFruitEaten; }
            set { numberOfFruitEaten = value; }
        }
        public Snake(List<int> xPosition, List<int> yPosition, int numberOfFruitEaten)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.numberOfFruitEaten = numberOfFruitEaten;
        }
        public void MoveLeft()
        {
            Xposition[0]--;
        }
        public void MoveRight()
        {
            Xposition[0]++;
        }
        public void MoveUp()
        {
            Yposition[0]--;
        }
        public void MoveDown()
        {
            Yposition[0]++;
        }

        public override string ToString()
        {
            Console.SetCursorPosition(Xposition[0], Yposition[0]);
            Console.WriteLine(((char)214).ToString());
            for(int i = 1; i <= numberOfFruitEaten; i++)
            {
                Console.SetCursorPosition(Xposition[i], Yposition[i]);
                Console.Write("o");
            }
            return "";
        }
    }
}
