using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            // Datentypen: ganze Zahlen; Dezimalzahlen, Zeichenketten; Zeichen, Wahrheitswerte (Boolean)
            // ganze Zahlen:
            int ganzeZahlA = 41;
            int ganzeZahlB;
            ganzeZahlB = 7;
            short kleineGanzeZahl;
            long großeGanzeZahl; 

            int ganzeZahlC = ganzeZahlA % ganzeZahlB;
            Console.WriteLine(ganzeZahlC);

            // Gleitkommazahlen (Dezimalzahlen)
            double gleitkommaZahlA = 1;
            double gleitkommaZahlB = 3;
            decimal großeGleitkommazahl;

            Console.WriteLine(gleitkommaZahlA / gleitkommaZahlB);

            double gleitkommazahlC = ganzeZahlC + gleitkommaZahlA;
            
            Console.WriteLine(gleitkommazahlC);
            // int zu double -> kein Problem
            // double zu int -> braucht Eingereifen

            bool wahrheitswert = true;
                // später mehr

            // Zeichen und Zeichenketten
            char zeichen = '&';
            string zeichenketteA = "Hallo Welt";
            string zeichenketteB = "bibi";

            // string + string := Kontaktenation
            Console.WriteLine(zeichenketteA + zeichenketteB);
        }
    }
}
