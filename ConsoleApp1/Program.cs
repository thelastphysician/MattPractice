using System;
using DataStructures;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int horzSize = 60;
            int vertSize = 30;

        
            GameOfLife gol = new GameOfLife(horzSize, vertSize,300);

            AsciiConverter ac = new AsciiConverter(horzSize, vertSize);

            //int iteration = 0;
            while (true)
            {
                Console.WriteLine(ac.AsciiToString(gol.StepGame()));
            }
           

            

        }
    }
}
