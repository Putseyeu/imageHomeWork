using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imageHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalImage = 52;
            int imagesInRow = 3;
            int totalRow = totalImage / imagesInRow;
            int totalOfExtraImages = totalImage - totalImage / imagesInRow * imagesInRow;

            Console.WriteLine (" completely filled rows " + totalRow + 
                " pictures will be beyond measure " + totalOfExtraImages);
        }
    }
}
