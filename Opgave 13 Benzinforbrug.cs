using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {

            //berzinforbrug

            string temp;
            Double km_pr_liter, forbrug, antalkm;

            //input

            Console.WriteLine("indtast kørtekilometer");
            temp = Console.ReadLine();
            antalkm = double.Parse(temp);

            Console.WriteLine("indtast forbrug");
            temp = Console.ReadLine();
            forbrug = double.Parse(temp);

            km_pr_liter = (forbrug / antalkm);


            if (km_pr_liter < 12)
            {
                Console.Write("køb en ny bil eller ændre kørestil anbefales");
            }


            if (km_pr_liter >= 12 && km_pr_liter < 16)

            {
                Console.Write("Ok forbrug");
            }


            if (km_pr_liter > 16 && km_pr_liter < 20)

            {
                Console.Write("flot kørsel");
            }


            if (km_pr_liter > 20 && km_pr_liter < 30)
            {
                Console.Write("super flot kørsel");
            }

            if (km_pr_liter > 30 )
            {
                Console.Write("elite bilist");
            }

            Console.ReadLine();












        }
    }
}
