using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                switch (i)
                {
                    case 1: Console.WriteLine(" ****  ***  ***    ***  ***  *    * ***  **");
                        break;
                    case 2 : Console.WriteLine(" *   *  *  *   *  *    *   * **   * *    ** ");
                        break;
                    case 3: Console.WriteLine(" *   *  *  *   *  *    ***** * *  * **   **");
                        break;
                    case 4: Console.WriteLine(" *   *  *  *   *  *    *   * *   ** *    ");
                        break;
                    case 5: Console.WriteLine(" ****  ***  ***    *** *   * *    * ***  **");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
