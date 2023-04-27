using KonzolovaAplikace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolovaAplikace
{
    class Pojistenec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public byte Vek { get; set; }
        public string TelefonniCislo { get; set; }
        public string TypPojisteni { get; set; }

        public Pojistenec(string jmeno, string prijmeni, byte vek, string telefonniCislo, string typPojisteni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
            TypPojisteni = typPojisteni;

        }


        /// <summary>
        /// Vrací textovou reprezentaci seznamu všech pojišťěných
        /// </summary>
        /// <returns>Jméno, Příjmení, Věk, Tel. číslo pojištěných</returns>
        public override string ToString()
        {
            return $"Jméno: {Jmeno}\t\t|Příjmení: {Prijmeni}\t\t|Věk: {Vek}\t|Tel. číslo: {TelefonniCislo}\t\t|Typ pojištění: {TypPojisteni}";
        }
    }
}
