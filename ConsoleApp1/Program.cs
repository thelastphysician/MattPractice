using System;
using DataStructures;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {





            int horzSize = 30;
            int vertSize = 30;

            ArrayList<ArrayList<int>> prevmatrix = new ArrayList<ArrayList<int>>(true);
            //init

            for (int i = 0; i < vertSize; ++i)
            {
                ArrayList<int> addition = new ArrayList<int>();
                for (int j = 0; j < horzSize; ++j)
                {
                    if(i > 4 && j > 5 && j < 10)
                    {
                        addition.Append(255);
                    }
                    else
                    {
                        addition.Append(0);
                    }
                    
                }
                prevmatrix.Append(addition);
                
            }

            AsciiConverter ac = new AsciiConverter(horzSize, vertSize);

            int iteration = 0;
            while (true)
            {
                ArrayList<ArrayList<int>> matrix = new ArrayList<ArrayList<int>>(true);

                for (int i = 0; i < vertSize; ++i)
                {
                    ArrayList<int> addition = new ArrayList<int>();
                    for (int j = 0; j < horzSize; ++j)
                    {
                        int avr = 0;


                        if(i-1 > 0)
                        {
                            avr += prevmatrix.Index(i - 1).Index(j);
                        }
                        if(j+1 < horzSize)
                        {
                            avr += prevmatrix.Index(i).Index(j + 1);
                        }
                        if(i+1 < vertSize)
                        {
                            avr += prevmatrix.Index(i + 1).Index(j);
                        }
                        if(j-1 > 0)
                        {
                            avr += prevmatrix.Index(i).Index(j - 1);
                        }


                        if (i - 1 > 0 && j+1 <horzSize)
                        {
                            avr += prevmatrix.Index(i - 1).Index(j+1);
                        }
                        if (i + 1 < vertSize && j + 1 < horzSize  )
                        {
                            avr += prevmatrix.Index(i+1).Index(j + 1);
                        }
                        if (i + 1 < vertSize && j -1  >0)
                        {
                            avr += prevmatrix.Index(i + 1).Index(j-1);
                        }
                        if (i-1 > 0 && j - 1 > 0)
                        {
                            avr += prevmatrix.Index(i-1).Index(j - 1);
                        }





                        if (prevmatrix.Index(i).Index(j) >127) //alive
                        {
                            if(avr >= 255 +255 && avr <= 255 + 255 +255) //two or three
                            {
                                addition.Append(255);
                            }
                            else
                            {
                                addition.Append(0); //too few or too many so die
                            }
                        }
                        else //dead
                        {
                            if(avr >= 255 + 255 + 255)//come back to life
                            {
                                addition.Append(255);
                            }
                            else
                            {
                                addition.Append(prevmatrix.Index(i).Index(j) - prevmatrix.Index(i).Index(j)/2);
                            }
                        }
                        
                        



                    }
                    matrix.Append(addition);
                    
                }
                
                
                Console.Write(ac.AsciiToString(prevmatrix));
                prevmatrix = matrix;

                System.Threading.Thread.Sleep(300);
                //Console.Read();


                ++iteration;
            }
           

            

        }
    }
}
