using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //tysklandstur 
            string temp;
            Double nyttevægt, ølramme, procent;
            //input

            Console.WriteLine("indtast nyttevægt");
            temp = Console.ReadLine();
            nyttevægt = 475 - double.Parse(temp);

            Console.WriteLine("indtast ølramme");
            temp = Console.ReadLine();
            ølramme = double.Parse(temp);

            procent = (ølramme * 8.5 * 100) /nyttevægt;

            if (procent > 100)
            {
                Console.Write("hvis procenten overstiger 100 kan i ikke have så mange rammer med");  
            }

            
            if((procent >= 90) && (procent < 100))
            {
                Console.Write("hvis procenten er lig med 90 og mindre end 100 skal du pas på, tæt på vægtgrænsen");   
            }
        

            if (procent <= 70 && procent < 90)
                
            {
                Console.Write("hvis procenten er lig med 70 og mindre end 90 skal programmet skrive, husk at sætte dæktrykket lidt op og justere forlygterne lidt ned");

            
            }
            
            
            
            
            if (procent >= 30 && procent < 70)
            {

                Console.Write("hvis procenten er lig med 30 og mindre end 70 skal programmet skrive, god tur");
            }
            


            
        
        
            

          
 
        
        
        }
    }
}
