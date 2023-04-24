using KonzolovaAplikace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KonzolovaAplikace
{
    class Pojistovna
    {
        private List<Pojistenec> seznamPojistenych = new List<Pojistenec>();

        public void VytvoritPojisteneho()
        {
            Console.WriteLine("Zadejte křestní jméno pojištěného:");
            string jmeno = Console.ReadLine().Trim();

            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni = Console.ReadLine().Trim();

            /// <summary>
            /// Cyklus se opakuje do doby, dokud není zadán validní vstup (věk pojištěného)
            /// </summary>
            byte vek;
            bool validniVstup = false;

            do
            { 
                Console.WriteLine("Zadejte věk pojištěného:");
                string vstup = Console.ReadLine().Trim();

                if (byte.TryParse(vstup, out vek) && vek > 0)
                {
                    validniVstup = true;
                }
                else
                {
                    Console.WriteLine("Chybný vstup, zadejte věk znovu.");
                }

            } 
            while (!validniVstup);

            string telefonniCislo = "";
            bool validni = false;

            Console.WriteLine("Zadejte typ pojištění:");
            string typPojisteni = Console.ReadLine().Trim();
            /// <summary>
            /// Cyklus se opakuje do doby, dokud není zadán validní vstup (telefonní číslo pojištěného)
            /// </summary>
            while (!validni)
            {
                Console.WriteLine("Zadejte telefonní číslo pojištěného:");
                telefonniCislo = Console.ReadLine().Replace(" ", "").Trim();

                if (telefonniCislo.Length != 9)
                {
                    Console.WriteLine("Zadali jste nesprávné telefonní číslo!");
                }
                else
                {
                    bool jeTelefonniCislo = int.TryParse(telefonniCislo, out int vysledek);
                    if (!jeTelefonniCislo)
                    {
                        Console.WriteLine("Zadali jste nesprávné telefonní číslo!");
                    }
                    else
                    {
                        validni = true;
                        Console.WriteLine("Pojištěnec {0} {1} byl úspěšně vytvořen.\n\nPokračujte libovolnou klávesou...", jmeno, prijmeni);
                    }
                }
            }

            seznamPojistenych.Add(new Pojistenec(jmeno, prijmeni, vek, telefonniCislo, typPojisteni));

        }

        /// <summary>
        /// Vypíše seznam všech pojištěných klientů
        /// </summary>
        public void ZobrazitSeznamPojistenych()
        {
            Console.WriteLine("Seznam všech pojištěných:");

            foreach (Pojistenec pojistenec in seznamPojistenych)
            {
                Console.WriteLine(pojistenec);
            }
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
        }
        /// <summary>
        /// Vyhledá pojištěného podle jména a příjmení
        /// </summary>
        public void VyhledatPojisteneho()
        {
            Console.WriteLine("Zadejte křestní jméno pojištěného:");
            string jmenoHledaneho = Console.ReadLine().Trim();
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeniHledaneho = Console.ReadLine().Trim();

            bool nalezen = false;
            foreach (Pojistenec pojistenci in seznamPojistenych)
            {
                if (pojistenci.Jmeno == jmenoHledaneho && pojistenci.Prijmeni == prijmeniHledaneho)
                {
                    Console.WriteLine("Pojištěný Nalezen:");
                    Console.WriteLine(pojistenci.ToString());
                    nalezen = true;
                    break;
                }               
            }

            if (!nalezen)
            {
                Console.WriteLine("Pojištěný Nenalezen!");
            }

            Console.WriteLine("\nPokračujte libovolnou klávesou...");
        }

        /// <summary>
        /// Odebere pojištěného ze seznamu pojištěných
        /// </summary>
        public void OdebratPojisteneho()
        {
            Console.WriteLine("Zadejte křestní jméno pojištěného:");
            string jmeno = Console.ReadLine().Trim();

            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni = Console.ReadLine().Trim();

            byte vek;
            bool validniVstup = false;

            do
            {
                Console.WriteLine("Zadejte věk pojištěného:");
                string vstup = Console.ReadLine().Trim();

                if (byte.TryParse(vstup, out vek) && vek > 0)
                {
                    validniVstup = true;
                }
                else
                {
                    Console.WriteLine("Chybný vstup, zadejte věk znovu.");
                }

            }
            while (!validniVstup);

            Pojistenec? odebran = null;

            foreach (Pojistenec pojistenci in seznamPojistenych)
            {
                if (pojistenci.Jmeno == jmeno && pojistenci.Prijmeni == prijmeni && pojistenci.Vek == vek)
                {
                    odebran = pojistenci;
                    break;
                }
            }

            if (odebran != null)
            {
                seznamPojistenych.Remove(odebran);
                Console.WriteLine("Pojištěnec {0} {1} byl úspěšně odebrán ze seznamu.", odebran.Jmeno, odebran.Prijmeni);
                odebran = null;
            }
            else
            {
                Console.WriteLine("Pojištěnec nebyl nalezen!");
            }
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
        }
    }
}
