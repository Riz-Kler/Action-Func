
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    // delegate void Operation(int num);

    // delegate int Operation(int num);

    class Program
    {
        static void Main(string[] args)

        {
            int input = 4;



            Action <int> op = num=>
                   {
                       Console.WriteLine("{0} x 2 = {1}", num, num * 2);
                   };
            op(2);


            Func<int, int> Double = num => { return num * 2; };

            Console.WriteLine("{0} x 2 = {1}", input, Double(input));


            Console.ReadLine();


        }
    }
}
