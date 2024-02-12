using System;
using System.Collections.Generic;
using System.Text;

class Menu
{
    private Dictionary<int, string> menuItems;

    public Menu()
    {
        menuItems = new Dictionary<int, string>()
        {
            {1, "Coca Cola 150 ml (€ 2.50)"},
            {2, "Insalata di pollo (€ 5.20)"},
            {3, "Pizza Margherita (€ 10.00)"},
            {4, "Pizza 4 Formaggi (€ 12.50)"},
            {5, "Pz patatine fritte (€ 3.50)"},
            {6, "Insalata di riso (€ 8.00)"},
            {7, "Frutta di stagione (€ 5.00)"},
            {8, "Pizza fritta (€ 5.00)"},
            {9, "Piadina vegetariana (€ 6.00)"},
            {10, "Panino Hamburger (€ 7.90)"}
        };
    }

    public void DisplayMenu()
    {
        Console.WriteLine("==============MENU==============");
        foreach (var item in menuItems)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        Console.WriteLine("==============MENU==============");
    }

    public decimal GetItemPrice(int menuItemNumber)
    {
        if (menuItems.ContainsKey(menuItemNumber))
        {
            string menuItem = menuItems[menuItemNumber];
            int euroIndex = menuItem.LastIndexOf('€') + 1;
            int endIndex = menuItem.LastIndexOf(')');
            string priceString = menuItem.Substring(euroIndex, endIndex - euroIndex).Trim();
            return decimal.Parse(priceString, System.Globalization.CultureInfo.InvariantCulture);
        }
        else
        {
            return 0.0m; // Ritorna 0 se l'articolo non è nel menu
        }
    }

    public Dictionary<int, string> GetMenuItems()
    {
        return menuItems;
    }
}
