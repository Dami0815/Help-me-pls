//I Use C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_agaain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool istGelöst = false; //Erstellt eine Variable die sagt ob die Aufgabe richtig gelöst wurde
            Console.WriteLine("Löse die Aufgaben"); //Gibt löse die Aufgabe aus
            while (!istGelöst) //Gehe in diesen Loop solange die Aufgabe nicht gelöst ist
            {
                Console.Write("234 + 354 = "); // Gebe Die Aufgabe aus

                string Lösung = Console.ReadLine(); //Lese die Eingabe für die Antwort und speichere sie in Lösung

                if (!string.IsNullOrWhiteSpace(Lösung)) //Wenn die eingabe nicht leer ist also " " oder "" gebe die antwort aus
                {
                    Console.Write("Antwort ist " + Lösung + ". "); //Antwort ausgeben. Es wird aber in der gleichen Consolenzeile ausgegeben.
                }
                else
                    Lösung = "Nichts"; //Wenn die Antwort leer wahr setze lösung auf "Nichts"

                int Antwort = 0; //Inizalisiere den Wert Antwort

                /*Versuche den text in Lösung zu einer zahl zu machen wenn es
                 gelingt speichere die zahl aus den Text Lösung in Antwort.
                 Wenn es nun gelingt die zahl zu speichern und diese zahl
                 588 ist. Gebe richtig aus.*/
                if (int.TryParse(Lösung, out Antwort) && Antwort == 588)
                {
                    Console.Write("Richtig"); // Gebe Richtig in der gleichen zeile wie die Antwort aus weil die Zahl richtig ist.
                    istGelöst = true; // Setze istGelößt auf true. Somit wird der Loop unterbrochen weil die richtige Antwort gegeben wurde
                }
                else
                {
                    Console.Write("Falsch"); // Wenn es keine Zahl ist oder nicht die Richtige sage es ist Falsch in der gleichen zeile wie die Antwort.
                }

                //Gleiche Zeile gleich: Antwort ist X. Falsch / Richtig 

                Console.WriteLine(); // gehe in die nächste Zeile

                //Wenn die aufgabe gelößt wurde wird hier der loop gebrochen wenn nicht wird er wiederholt
            }

            istGelöst = false; // Setze istGelößt wieder auf false weil eine neue aufgabe angefangen wird und die noch nicht gelößt wurde
            while (!istGelöst) //wieder diesen loop ausführen solange es nicht gelößt ist.
            {

                //Gibt die Fragen und die Antwortmöglichkeiten aus
                Console.WriteLine("Wieviele Bundesländer hat Deutschland?");
                Console.WriteLine("A :10");
                Console.WriteLine("B :16");
                Console.WriteLine("C :14");
                Console.Write("Antwort: "); // Fragt nach der Antwort

                string Lösung = Console.ReadLine(); // Nimmt die Eingabe und speicgert sie in Lösung

                if (!string.IsNullOrWhiteSpace(Lösung)) // Gebe die Eingabe von dem Nutzer wieder nur aus wenn sie nicht nichts ist
                    Console.Write("Antwort ist " + Lösung + ". ");

                /*Wenn es die richtige antwort ist gebe richtig aus. 
                 Lösung.Upper() heißt das alle buchstaben groß
                werden also das man auch b eingeben kann weil das mit .Upper() zu B wird.*/
                if (Lösung.ToUpper() == "B")
                {
                    Console.Write("Richtig!"); // Gibt aus das es Richtig war wieder in der gleichen Zeile.
                    istGelöst = true; // Setzt das die Frage beantwortet wurde auf wahr
                }
                /*Wenn die lösung nicht die ein buchstabe von den Möglichkeiten war
                  oder eine Zahl oder Gar nichts gebe aus das es eine möglickeit sein muss                 
                 */
                else if (Lösung.ToUpper() != "A" && Lösung.ToUpper() != "B" || !string.IsNullOrWhiteSpace(Lösung))
                {
                    Console.Write("Falsch!. Deine Antwort muss ein Buchstabe von den Möglickeiten sein"); // Ausgabe das man einen Buchstaben von den Möglichkeiten braucht
                }
                else
                {
                    Console.Write("Falsch!"); // Wenn es nicht richtig ist gebe aus das es falsch ist.
                }

                Console.WriteLine(); //Gehe wieder in eine neue Zeile.

                //Wenn die aufgabe gelößt wurde wird hier der loop gebrochen wenn nicht wird er wiederholt
            }
            Console.ReadKey(); // Programm wird beended wenn eine Taste gedrückt wurde


        }
    }
}