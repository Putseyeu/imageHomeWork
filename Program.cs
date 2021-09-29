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
            int imageOneRow = 3;
            int totalRow = totalImage / imageOneRow;
            int excessImage = totalImage - (totalRow * 3);

            Console.WriteLine (" completely filled rows  " + totalRow + 
                " pictures will be beyond measure " + excessImage);
        }
    }
}
