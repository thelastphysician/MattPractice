using System;
using DataStructures;

public  class AsciiConverter{
    int horz;
    int vert;
    //0-255 -> 0-69
    //string asciiTable = "$@B%8&WM#*aqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\"^`'. ";
    string asciiTable = " .'`^\",:; Il!i><~+_-?][}{1)(|\\/tfjrxnuvczXYUJCLQ0OZmwqb*#MW&8%B@$";
    public AsciiConverter(int horz, int vert)
    {
        this.horz = horz;
        this.vert = vert;
    }

    
    public string AsciiToString(ArrayList<ArrayList<int>> input)
    {
        string ret = "";
        //convert matrix with 0-255 to string of 0-63
        for(int vertIndex = 0; vertIndex < vert; ++vertIndex)
        {
            for (int horzIndex = 0; horzIndex < horz; ++horzIndex)
            {
                if(vertIndex < input.Count && horzIndex < input.Index(0).Count)
                {
                     ret += UtilConv(input.Index(vertIndex).Index(horzIndex));
                }
                else
                {
                    ret += " ";
                }
                ret += " ";
            }
            ret += "\n";
        }
        
        return ret;
    }

    private char UtilConv(int value)
    {
        if(value > 255 )
        {
            return asciiTable[63];
        }else if(value < 0)
        {
            return asciiTable[0];
        }
        
        return asciiTable[value / 4];
    }
} 
