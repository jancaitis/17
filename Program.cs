using System;

namespace projektz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number of arrays: ");
            string inputarray = Console.ReadLine();
            int numberofarray = Convert.ToInt32(inputarray);
            string[] arrayz = new string[numberofarray];
            string sep = "";
            string beigas = "";

            for (int i = 0; i < numberofarray; i++)
            {
                Console.Write("write some words to collect: ");
                string newinput = Console.ReadLine();
                string newArray = Convert.ToString(newinput);
                arrayz[i] = newArray;
                
            }
         
            for (int i = 0; i < numberofarray; i++)
            {  
                if (!(beigas.Contains(arrayz[i])))
                {
               beigas += sep + arrayz[i];
               sep = ",";
                }
            }
            
            Console.Write($"{beigas}");
        }
    }
}
