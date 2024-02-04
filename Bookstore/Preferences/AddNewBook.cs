namespace Bookstore.Preferences
{
    internal class AddNewBook
    {
        internal static string[] newBookTitle = new string[AspectsOfBooks.Titles.bookTitle.Length + 1];
        internal static string[] newBookAuthor = new string[AspectsOfBooks.Authors.bookAuthor.Length + 1];
        internal static string[] newBookGenre = new string[AspectsOfBooks.Genres.bookGenre.Length + 1];
        internal static string[] newBookPrice = new string[AspectsOfBooks.Prices.bookPrice.Length + 1];
        internal static string[] newBookInStock = new string[AspectsOfBooks.Stock.inStock.Length + 1];
        internal static string enterNewBookTitle;
        internal static string enterNewBookAuthor;
        internal static string enterNewBookGenre;
        internal static double enterNewBookPrice;

        internal static void AddABook()
        {
            Console.WriteLine();
            Console.WriteLine("Add new book!");
            Console.WriteLine();
            Console.WriteLine("Enter book title:");
            Console.WriteLine();
            enterNewBookTitle = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter book Author:");
            Console.WriteLine();
            enterNewBookAuthor = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("Enter book genre:");
            Console.WriteLine();
            enterNewBookGenre = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("Enter book price:");
            Console.WriteLine();

            try
            {
                enterNewBookPrice = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong price format.");
                Console.WriteLine();
                Selection.SelectedMenuItem();
            }

            for (int i = 0; i < AspectsOfBooks.Titles.bookTitle.Length; i++)
            {
                newBookTitle[i] = AspectsOfBooks.Titles.bookTitle[i];
                newBookAuthor[i] = AspectsOfBooks.Authors.bookAuthor[i];
                newBookGenre[i] = AspectsOfBooks.Genres.bookGenre[i];
                newBookPrice[i] = AspectsOfBooks.Prices.bookPrice[i];
                newBookInStock[i] = AspectsOfBooks.Stock.inStock[i];
            }

            newBookTitle[10] = enterNewBookTitle;
            newBookAuthor[10] = enterNewBookAuthor;
            newBookGenre[10] = enterNewBookGenre;
            newBookPrice[10] = "$" + enterNewBookPrice.ToString();
            newBookInStock[10] = "true";

            AspectsOfBooks.Titles.bookTitle = newBookTitle;
            AspectsOfBooks.Authors.bookAuthor = newBookAuthor;
            AspectsOfBooks.Genres.bookGenre = newBookGenre;
            AspectsOfBooks.Prices.bookPrice = newBookPrice;
            AspectsOfBooks.Stock.inStock = newBookInStock;


            //Console.WriteLine(newBookTitle[10]);
            //Console.WriteLine(newBookAuthor[10]);
            //Console.WriteLine(newBookGenre[10]);
            //Console.WriteLine(newBookPrice[10]);
            //Console.WriteLine(newBookInStock[10]);
            //for (int i = 0; i < AspectsOfBooks.Titles.bookTitle.Length; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine(AspectsOfBooks.Titles.bookTitle[i]);
            //    Console.WriteLine(AspectsOfBooks.Authors.bookAuthor[i]);
            //    Console.WriteLine(AspectsOfBooks.Genres.bookGenre[i]);
            //    Console.WriteLine(AspectsOfBooks.Prices.bookPrice[i]);
            //    Console.WriteLine(AspectsOfBooks.Stock.inStock[i]);
            //}
        }
    }
}
