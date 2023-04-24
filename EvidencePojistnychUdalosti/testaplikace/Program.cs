using KonzolovaAplikace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolovaAplikace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            ______________________________________________________________________________  
                          ______
            	         / ____/    __     __               
             	        / /___   __/_/____/ /__  __   __ _______
             	       / ___/ | / / // __  / _ \/  | / / ___/ _ \
                      / /___| |/ / // /_/ /  __/ | |/ / /__/  __/
             	     /_____/|___/_/ \__,_/\___/_/|___/\___/\___/                            
                           / __ \            __ _,_        _,_           ____
                          / /_/ /__       __/_/|__/_______|__/ __   ____/___/______
                         / ____/ __ \ _  / / / ___/__  __/ _ \/  | / / /_/ / ___/ /_
                        / /   / /_/ / /_/ / /__  /  / / /  __/ | |/ /\_  _/ /__/ __ \     
                       /_/    \____/_____/_/____/  /_/  \___/_/|___/  /_/ \___/_/ /_/     
            _____________________________________________________________________________");
            Console.WriteLine("\n");

            Pojistovna pojistovna = new Pojistovna();

            /// <summary>
            /// Vypíše akce, které nabízí typ operace
            /// </summary>
            while (true)
            {
                Console.WriteLine("Vyberte si Akci:");
                Console.WriteLine("1 | - Přidat nového pojištěného");
                Console.WriteLine("2 | - Vypsat všechny pojištěné");
                Console.WriteLine("3 | - Vyhledání pojištěného");
                Console.WriteLine("4 | - Odebrat pojištěného");
                Console.WriteLine("5 | - Konec aplikace");
                Console.WriteLine();

                Console.Write("Akce: ");
                int volba;
                while (!int.TryParse(Console.ReadLine(), out volba) || (volba < 1 && volba > 5))
                {
                    Console.WriteLine("Chybná akce. Zvolte prosím 1, 2, 3, 4 nebo 5.");
                }

                switch (volba)
                {
                    case 1:
                        pojistovna.VytvoritPojisteneho();
                        break;

                    case 2:
                        pojistovna.ZobrazitSeznamPojistenych();
                        break;

                    case 3:
                        pojistovna.VyhledatPojisteneho();
                        break;

                    case 4:
                        pojistovna.OdebratPojisteneho();
                        break;

                    case 5:
                        Console.WriteLine("Konec aplikace.");
                        return;

                    default:
                        Console.WriteLine("Neplatná volba. Zkuste to prosím znovu.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}