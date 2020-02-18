using System;
using DataStructures;
using Utility;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int horzSize = 60;
            int vertSize = 30;

        
            GameOfLife gol = new GameOfLife(horzSize, vertSize,300);

            AsciiConverter ac = new AsciiConverter(horzSize, vertSize);

            //int iteration = 0;
            while (true)
            {
                Console.WriteLine(ac.AsciiToString(gol.StepGame()));
            }
           
            */

            Random rand = new Random();
            ArrayList<int> al = new ArrayList<int>();
            for(int i = 0; i < 100; ++i)
            {
                al.Append(rand.Next(0,100));
            }

            al.Display();
            
            Utility<int>.BubbleSort(al);
            al.Display();
            Console.Read();
            
            

            

        }
    }
}
