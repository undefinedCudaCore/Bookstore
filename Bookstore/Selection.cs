using Bookstore.Preferences;

namespace Bookstore
{
    internal class Selection
    {
        internal static string selectedMenuItem;

        internal static void Select()
        {
            Console.WriteLine("Enter selection number:");
            Console.WriteLine("1. Browse books by title.");
            Console.WriteLine("2. Search books by genre.");
            Console.WriteLine("3. Get total value of inventory.");
            Console.WriteLine("4. Choose genre for a discount.");
            Console.WriteLine("5. Add a New Book.");
            Console.WriteLine("6. Remove a Book.");
            Console.WriteLine();

            selectedMenuItem = Console.ReadLine();
        }

        internal static void SelectedMenuItem()
        {
            Select();

            switch (selectedMenuItem)
            {
                case "1":
                    Console.WriteLine("Please enter book title:");
                    BrowsingBooks.SearchForBookByTitle();
                    break;

                case "2":
                    Console.WriteLine("Please enter book genre:");
                    SearchingForBooks.SearchForBookByGenre();
                    break;

                case "3":
                    ValueOfInventory.InventoryValue();
                    break;

                case "4":
                    DiscountOnGenre.GetDiscount();
                    break;

                case "5":
                    Console.WriteLine();
                    break;

                case "6":
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("You have to select one menu item. Please enter items number:");
                    Select();
                    break;

            }
        }
    }
}
