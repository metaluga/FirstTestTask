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
            int N = 5;

            int[,] myImg = new int[N, N];
            int k=1;
            for(int i=0; i<N; i++)
            {
                for (int j = 0; j < 5; j++)
                    myImg[i, j] = k++;
            }

            Console.WriteLine("initial array");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(myImg[i, j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("\narray after algorithm");
            myImg = Rotation.rotates_images(myImg);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(myImg[i, j] + " ");
                Console.WriteLine();
            }

           



        }
    }
}
