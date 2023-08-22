using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox08
{
    class Fruit
    {
        private int xPosition;
        private int yPosition;
        public int Xposition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public int Yposition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public override string ToString()
        {
            Random random = new Random();
            Xposition = random.Next(2, Console.WindowWidth - 2);
            Yposition = random.Next(2, Console.WindowHeight - 2);
            Console.SetCursorPosition(Xposition, Yposition);
            return ((char)64).ToString();
        }
    }
}
