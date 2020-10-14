using System;

namespace DevolverLetras
{
    class Program
    {
        static void Main(string[] args)
        {
           letra("Z");

        }
         
        static void letra(string letra)
        {
            string linea = "";

            for (int row = 0; row < 7 ;row++)
            {
                for (int column = 0; column < 7 ; column++)
                {
                    //letra V
                    if(letra == "V")
                    {
                    linea += (column == 0 || column == 6) && (row == 0 || row == 1) ? "*": 
                    (column == 1 || column == 5) && (row == 2 || row == 3) ? "*": 
                    (column == 2 || column == 4) && (row == 4 || row == 5) ? "*": 
                    (column == 3) && (row == 6) ? "*": " ";
                    }

                    if(letra == "Z")
                    {
                    //letra Z
                    linea += (column >= 0 || column <= 6) && (row == 0 || row == 6) ? "*": 
                    (column == 1 && row == 5) ? "*": (column == 2 && row == 4) ? "*": 
                    (column == 3 && row == 3) ? "*": (column == 4 && row == 2) ? "*": 
                    (column == 5 && row == 1) ? "*":  " ";
                    }
                }
                Console.WriteLine(linea);
                linea = "";
            }
        }
    }
}
