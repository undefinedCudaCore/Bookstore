namespace Bookstore.Preferences
{
    internal class ValueOfInventory
    {
        private static double sumOfBooksInInventory;

        internal static void InventoryValue()
        {
            for (int i = 0; i < AspectsOfBooks.Titles.bookTitle.Length; i++)
            {
                if (AspectsOfBooks.Stock.inStock[i] == "true")
                {
                    sumOfBooksInInventory += double.Parse(AspectsOfBooks.Prices.bookPrice[i].Substring(1));
                }
                //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[i].Substring(1) + " " + AspectsOfBooks.Stock.inStock[i]);
            }
            Console.WriteLine($"Total Value of Inventory is: ${Math.Round(sumOfBooksInInventory, 2)}");
        }
    }
}
