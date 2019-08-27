/*
 * Aufgabe: Der Benutzer dieser Anwendung soll eine vom System generierte Zufallszahl
 *          zwischen 1 und 100 in maximal 7 Versuchen erraten.
 * 
 *          Dabei sollen als Lösungstipps nach jedem Rateversuch ein entsprechender
 *          Hinweis "zu groß" bzw. "zu klein" ausgegeben werden. Nach 7 Versuchen,
 *          oder bei Eingabe der gesuchten Zahl, soll abgebrochen werden.
 */


using System;

namespace Uebung07ZahlenRaten
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxVersuche = 7;
            int anzahlVersuche = 0;
            string eingabe = "";
            int zahl = 0;
            bool istZahl = false;

            int ausgedachtezahl = 0;
            Random rng = new Random();

            ausgedachtezahl = rng.Next(1,100);

            Console.WriteLine("Ich denke mir eine Zahl zwischen 0 und 100. Rate sie. Du hast {0} Versuche", maxVersuche);

            Console.WriteLine("Gesucht wird die Zahl {0}", ausgedachtezahl);

            while (anzahlVersuche < maxVersuche)
            {
                Console.WriteLine("Rate... du hast noch {0} Versuche", maxVersuche - anzahlVersuche);
                anzahlVersuche++;

                istZahl = false;
                while (!istZahl)
                {
                    eingabe = Console.ReadLine();
                    istZahl = int.TryParse(eingabe, out zahl);

                    if((zahl < 1) || (zahl > 99) )
                    {
                        Console.WriteLine("Ich sagte ZAHLEN zwischen 0 und 100 also >> 1...99 << du Idiot");
                        istZahl = false;
                    }  
                }

                if(zahl == ausgedachtezahl)
                {
                    Console.WriteLine("WOW Du hast die Zahl gefunden TOLL");
                    break;
                }
                else if(zahl < ausgedachtezahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist groesser");
                }
                else
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner");
                }

                if(anzahlVersuche == maxVersuche)
                {
                    Console.WriteLine("Keine Versuche mehr! Schade...");
                    Console.WriteLine("Die gesuchte Zahl war {0}", ausgedachtezahl);
                }
            }

            Console.ReadKey();
        }
    }
}
