using System;
namespace Uppgift_5_1
{

    class Program
    {
        static void Main()
        {
          string[] Stränger = new string[4];
            Stränger[0] = "förstsa mening";

            Stränger[1] = "andra mening";

            Stränger[2] = "Tedje mening";

            Stränger[3] = "Fjärde mening";

            for (int i = 0; i < Stränger.Length; i++)
            {
                Console.WriteLine(Stränger[i]+"\n"); 
            }    


        }

    }

}
