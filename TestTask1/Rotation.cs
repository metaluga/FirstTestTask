using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask1
{
    class Rotation
    {
        public static int[,] rotates_images(int[,] img)
        {
            int scale = img.GetUpperBound(0) + 1;
            
            for (int i = 0; i <= scale / 2; i++)
            {
                for (int j = i; j <scale -i -1; j++)
                {
                    int tmp = img[scale - 1 - j, i]; 
                    img[scale - 1 - j, i] = img[scale - 1 - i, scale - 1 - j];
                    img[scale - 1 - i, scale - 1 - j] = img[j, scale - 1 - i];
                    img[j, scale - 1 - i] = img[i, j];
                    img[i, j] = tmp;
                }
            }
            return img;
        }


    }
}
