using System;
using DataStructures;
public class GameOfLife
{

	ArrayList<ArrayList<int>> prevmatrix;

    int horzSize;
    int vertSize;
    int deltaTime;
	public GameOfLife(int horz, int vert, int deltaTime)
	{
        this.horzSize = horz;
        this.vertSize = vert;
        this.deltaTime = deltaTime;

		prevmatrix = new ArrayList<ArrayList<int>>(true);
        //initilize matrix
        for (int i = 0; i < vertSize; ++i)
        {
            ArrayList<int> addition = new ArrayList<int>();
            for (int j = 0; j < horzSize; ++j)
            {
                if (i > 4 && j > 5 && j < 10)
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

    }

    public ArrayList<ArrayList<int>> StepGame()
    {
        ArrayList<ArrayList<int>> matrix = new ArrayList<ArrayList<int>>(true);

        for (int i = 0; i < vertSize; ++i)
        {
            ArrayList<int> addition = new ArrayList<int>();
            for (int j = 0; j < horzSize; ++j)
            {
                int avr = 0;


                if (i - 1 > 0)
                {
                    avr += prevmatrix.Index(i - 1).Index(j);
                }
                if (j + 1 < horzSize)
                {
                    avr += prevmatrix.Index(i).Index(j + 1);
                }
                if (i + 1 < vertSize)
                {
                    avr += prevmatrix.Index(i + 1).Index(j);
                }
                if (j - 1 > 0)
                {
                    avr += prevmatrix.Index(i).Index(j - 1);
                }


                if (i - 1 > 0 && j + 1 < horzSize)
                {
                    avr += prevmatrix.Index(i - 1).Index(j + 1);
                }
                if (i + 1 < vertSize && j + 1 < horzSize)
                {
                    avr += prevmatrix.Index(i + 1).Index(j + 1);
                }
                if (i + 1 < vertSize && j - 1 > 0)
                {
                    avr += prevmatrix.Index(i + 1).Index(j - 1);
                }
                if (i - 1 > 0 && j - 1 > 0)
                {
                    avr += prevmatrix.Index(i - 1).Index(j - 1);
                }





                if (prevmatrix.Index(i).Index(j) > 127) //alive
                {
                    if (avr >= 255 + 255 && avr <= 255 + 255 + 255) //two or three
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
                    if (avr >= 255 + 255 + 255)//come back to life
                    {
                        addition.Append(255);
                    }
                    else
                    {
                        addition.Append(prevmatrix.Index(i).Index(j) - prevmatrix.Index(i).Index(j) / 2);
                    }
                }





            }
            matrix.Append(addition);

        }

        
        prevmatrix = matrix;

        System.Threading.Thread.Sleep(deltaTime);

        return prevmatrix;
    }
}
