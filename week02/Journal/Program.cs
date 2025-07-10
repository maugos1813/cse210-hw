using System;

class Program
{
    static void Main()
    {
        Journal journal = new();
        bool running = true;

        while (running)
        {
            Console.WriteLine("--------- MENÚ ---------");
            Console.WriteLine("1. Escribir nueva entrada");
            Console.WriteLine("2. Mostrar el diario");
            Console.WriteLine("3. Guardar diario en archivo");
            Console.WriteLine("4. Cargar diario desde archivo");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción (1‑5): ");

            string choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (choice)
            {
                case "1": journal.AddEntry();       break;
                case "2": journal.Display();        break;
                case "3": journal.SaveToFile();     break;
                case "4": journal.LoadFromFile();   break;
                case "5": running = false;          break;
                default:  Console.WriteLine("Opción no válida.\n"); break;
            }
        }

        Console.WriteLine("¡Hasta luego!");
    }
}
