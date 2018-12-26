using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hellow_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            int x = 4 ;
            int b = 7;
            Console.WriteLine( x);

            Console.WriteLine("please enter ypur name");
            string name = Console.ReadLine();
            Console.Write("hello ");
            Console.WriteLine(name);
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
             if(a % 2==0)
            {
                // if true
                Console.WriteLine("zugi");
            }
             else
            {
                // if false
                Console.WriteLine("ee zugi");
            } 

      
        }
    }
}
