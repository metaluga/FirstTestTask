using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myImg = new int[5, 5];
            int k=1;
            for(int i=0; i<5; i++)
            {
                for (int j = 0; j < 5; j++)
                    myImg[i, j] = k++;
            }

            Console.WriteLine("initial array");
            foreach (int i in myImg)
                Console.Write(i + " ");

            Console.WriteLine("\n\narray after first algorithm");
            foreach (int i in Rotation.rotates_imagesM(myImg)) // algorithm with limited memory
                Console.Write(i + " ");

            Console.WriteLine("\n\narray after second algorithm");

            foreach (int i in Rotation.rotates_imagesF(myImg)) // algorithm with limited time
                Console.Write(i + " ");

        }
    }
}
