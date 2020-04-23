using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerTFO_Kofleo
{
    class Program
    {
        static void Main(string[] args)
        {
            Titel("MinirechnerTFO von Leon Kofler");
            Menu();
            
            
            Console.ReadKey();
            
        }

        static void Titel(string titel)
        {
            int breite = Console.WindowWidth;
            int textlen = titel.Length;

            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < (breite - textlen) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }
        static void Menu()
        {
            string Einlesen = "";
            Console.WriteLine("Menu");
            Console.WriteLine("Addiere         (1)");
            Console.WriteLine("Subtrahiere     (2)");
            Console.WriteLine("Multipliziere   (3)");
            Console.WriteLine("Dividiere       (4)");
            Console.Write("Wählen Sie die Aktion aus: ");
            Einlesen = Console.ReadLine();

            switch (Einlesen)
            {
                case "1":
                    {
                        Console.WriteLine("Addiere");
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Subtrahiere");
                    }
                    break;
                
                case "3":
                    {
                        Console.WriteLine("Multipliziere");
                    }
                    break;

                case "4":
                    {
                        Console.WriteLine("Dividiere");
                    }
                    break;

                default:
                    {
                    }
                    break;


            }

        }
        
       
    }
}
