using System.Collections.Generic;
using System.Text;
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        RunRestaurantApp();
    }

    static void RunRestaurantApp()
    {
        Menu menu = new Menu();
        List<int> selectedItems = new List<int>();

        while (true)
        {
            menu.DisplayMenu();

            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.Write("Seleziona un numero dal menu: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice >= 1 && choice <= 10)
                {
                    selectedItems.Add(choice);
                    Console.WriteLine($"{menu.GetMenuItems()[choice]} aggiunto al conto.");
                }
                else if (choice == 11)
                {
                    PrintFinalBill(menu, selectedItems);
                }
                else
                {
                    Console.WriteLine("Scelta non valida. Riprova.");
                }
            }
            else
            {
                Console.WriteLine("Inserire un numero valido. Riprova.");
            }

            Console.WriteLine();
        }
    }

    static void PrintFinalBill(Menu menu, List<int> selectedItems)
    {
        Console.WriteLine("==============CONTO FINALE==============");
        decimal totalCost = 0;

        foreach (var item in selectedItems)
        {
            Console.WriteLine($"{menu.GetMenuItems()[item]}");
            totalCost += menu.GetItemPrice(item);
        }

        totalCost += 3.00m; // Servizio al tavolo

        Console.WriteLine($"Costo totale: € {totalCost:F2}");
        Console.WriteLine("Grazie per aver usufruito del nostro servizio!");
        Console.WriteLine("==============CONTO FINALE==============");
    }
}