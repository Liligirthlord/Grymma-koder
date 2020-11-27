using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int äPris = 7;
            int pPris = 13;
            int antalTal;
            int antalTal1;

            Console.WriteLine("Hur många påron såldes?");
            antalTal1 = Convert.ToInt32(Console.ReadLine());
            {
                Console.WriteLine("Hur många äpplen såldes?");
                antalTal = Convert.ToInt32(Console.ReadLine());
            }
            if (antalTal * äPris == antalTal1 * pPris)
            {
                Console.WriteLine("De har sålt för lika mycket");

            }
            if (antalTal * äPris > antalTal1 * pPris)
            {
                Console.WriteLine("Äpplena har sålt för mer pengar");
            }
            if (antalTal1 * pPris > antalTal * äPris)
            {
                Console.WriteLine("Päronen har sålt för mer pengar");
            }
                }
            }
        }
    

        
   


