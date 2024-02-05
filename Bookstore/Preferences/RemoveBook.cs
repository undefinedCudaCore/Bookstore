using static System.Net.Mime.MediaTypeNames;

namespace Bookstore.Preferences
{
    internal class RemoveBook
    {
        internal static string enterBookTitleToRemove;
        internal static int count;
        internal static int count2;

        internal static void RemoveABook()
        {
            //for (int i = 0; i < AspectsOfBooks.Titles.bookTitle.Length; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------" + count++);
            //    Console.WriteLine(AspectsOfBooks.Titles.bookTitle[i]);
            //    Console.WriteLine(AspectsOfBooks.Authors.bookAuthor[i]);
            //    Console.WriteLine(AspectsOfBooks.Genres.bookGenre[i]);
            //    Console.WriteLine(AspectsOfBooks.Prices.bookPrice[i]);
            //    Console.WriteLine(AspectsOfBooks.Stock.inStock[i]);
            //}

            Console.WriteLine();
            Console.WriteLine("Enter book title to remove book from inventory:");
            Console.WriteLine();
            Console.WriteLine("Enter book title:");
            Console.WriteLine();
            enterBookTitleToRemove = Console.ReadLine();


            for (int i = 0; i < AspectsOfBooks.Titles.bookTitle.Length; i++)
            {
                if (enterBookTitleToRemove == AspectsOfBooks.Titles.bookTitle[i])
                {
                    AspectsOfBooks.Titles.bookTitle[i] = "";
                    AspectsOfBooks.Authors.bookAuthor[i] = "";
                    AspectsOfBooks.Genres.bookGenre[i] = "";
                    AspectsOfBooks.Prices.bookPrice[i] = "";
                    AspectsOfBooks.Stock.inStock[i] = "";
                }
            }

            AspectsOfBooks.Titles.bookTitle = AspectsOfBooks.Titles.bookTitle.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            AspectsOfBooks.Authors.bookAuthor = AspectsOfBooks.Authors.bookAuthor.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            AspectsOfBooks.Genres.bookGenre = AspectsOfBooks.Genres.bookGenre.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            AspectsOfBooks.Prices.bookPrice = AspectsOfBooks.Prices.bookPrice.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            AspectsOfBooks.Stock.inStock = AspectsOfBooks.Stock.inStock.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            //Console.WriteLine(newBookTitle[10]);
            //Console.WriteLine(newBookAuthor[10]);
            //Console.WriteLine(newBookGenre[10]);
            //Console.WriteLine(newBookPrice[10]);
            //Console.WriteLine(newBookInStock[10]);
            //for (int i = 0; i < AspectsOfBooks.Titles.bookTitle.Length; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------------------" + count2++);
            //    Console.WriteLine(AspectsOfBooks.Titles.bookTitle[i]);
            //    Console.WriteLine(AspectsOfBooks.Authors.bookAuthor[i]);
            //    Console.WriteLine(AspectsOfBooks.Genres.bookGenre[i]);
            //    Console.WriteLine(AspectsOfBooks.Prices.bookPrice[i]);
            //    Console.WriteLine(AspectsOfBooks.Stock.inStock[i]);
            //}
        }
    }
}
