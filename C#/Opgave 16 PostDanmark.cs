using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //erklæring af variabler
            string temp;
            Double pris =0, kg = 0;
            string pakketype = "";

            //input

            Console.WriteLine("indtast kg");
            temp = Console.ReadLine();
            kg = double.Parse(temp);
            
            Console.WriteLine("indtast f r v");
            pakketype = Console.ReadLine();

            
            if (pakketype == "f" || pakketype == "F"   ) 
            {

                pris = 4 + 1.8 * kg;
            }
            
            if (pakketype == "r")
            {
            pris = 5 + 1.7 * kg;
                   }
            
            if (pakketype == "v")
            {
                  pris = 6 + 1.9 * kg;
            }

            Console.WriteLine("total pris {0}", pris);
            Console.ReadLine();

            
} 
}
}