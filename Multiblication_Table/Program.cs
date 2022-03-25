using System;

namespace Multiblication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for( int i = 1; i < 13; i++)
            {
                for(int j = 1; j < 13; j++)
                {
                    Console.Write(i * j +"\t");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
