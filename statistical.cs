using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //input             
            string inputstring = Console.ReadLine();
            while (inputstring != "End")
            {
                string inputnumber = Console.ReadLine();
            }
            if (inputstring == "End")
            {
                string inputFind = Console.ReadLine();
                while (inputFind != "FindMax" || inputFind != "FindMin" || inputFind != "FindMean")
                {
                    Console.WriteLine("Invalid mode");
                    inputFind = Console.ReadLine();
                }
                    if (inputFind == "FindMax")
                    {
                        //int X = Math.Max(inputstring);
                        //Console.WriteLine(X);
                    }
                    else if (inputFind == "FindMin")
                    {
                        //int X = Math.Min(inputstring);
                        //Console.WriteLine(X);
                    }
                    else if (inputFind == "FindMean")
                    {
                        //double X = Math.Mean(inputstring);
                        //Console.WriteLine(X);
                    }
                

            }
        }
        
    }
}
