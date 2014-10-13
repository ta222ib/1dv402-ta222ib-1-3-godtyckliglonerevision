using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L03A
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInt("Ange antal löner att mata in: ");
            //Läs in antalet löner användaren vill mata in
            //hantera om användaren matar in färre än två "Du måste mata in ..."
            //Läs in ett godtyckligt antal löner
            //hantera om användaren matar in något annat än heltal, uppmana användaren att mata in heltal
            //Spara samtliga inmatade löner i en array av typen int[]
            //sortera arrayen med löner
            // Beräkna medianlön, medellön och lönespridning
            //Presentera resultaten formaterade som valuta
            //Presentera löneran i den ordning de matats in med tre löner per rad
            //Användaren skall kunna välja att avsluta prgrm genom att trycka ESC, annan tangent börjar om programmet

        }
        private static int ReadInt(string input)
        {
            int numberOfSalaries;

            do
            {
                Console.Write("{0}", input);
                numberOfSalaries = int.Parse(Console.ReadLine());
                if (numberOfSalaries < 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDu måste mata in minst två löner för att kunna göra en beräkning!");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nTryck tangent för ny beräkning - Esc avslutar.");
                    Console.ResetColor();
                    
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                Console.WriteLine("klar");
                   //Console.ReadKey();
                   // //Console.ReadKey(true).Key != ConsoleKey.Escape;
                   // //{
                   // //    break;
                   // //}
                    
           
	            
                
                    
                //    if (Console.ReadKey(true).Key != ConsoleKey.Escape);
                //      (Console.ReadKey(true).Key != ConsoleKey.Escape)
               return numberOfSalaries;
        }
}

        
    }

