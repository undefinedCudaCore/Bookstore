namespace Bookstore.Preferences
{
    internal class DiscountOnGenre
    {
        internal static string[] pricesAfterDiscount = new string[AspectsOfBooks.Prices.bookPrice.Length];
        internal static double price;
        internal static string enterGenre;
        internal static double enterDiscount;

        internal static void GetDiscount()
        {
            Console.WriteLine("Please enter genre:");
            enterGenre = Console.ReadLine();

            Console.WriteLine("Please enter discount percentage:");
            try
            {
                enterDiscount = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please check percentage and come back later.");
                Console.WriteLine();

                Selection.SelectedMenuItem();
            }

            for (int i = 0; i < pricesAfterDiscount.Length; i++)
            {
                price = double.Parse(AspectsOfBooks.Prices.bookPrice[i].Substring(1));

                if (enterGenre == AspectsOfBooks.Genres.bookGenre[i])
                {
                    price *= (1 - (enterDiscount * 0.01));
                }

                pricesAfterDiscount[i] = "$" + Math.Round(price, 2).ToString();
            }
            AspectsOfBooks.Prices.bookPrice = pricesAfterDiscount;

            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[0]);
            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[1]);
            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[2]);
            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[3]);
            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[4]);
            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[5]);
            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[6]);
            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[7]);
            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[8]);
            //Console.WriteLine(AspectsOfBooks.Prices.bookPrice[9]);
        }
    }
}
