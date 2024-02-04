namespace Bookstore.Preferences
{
    internal class BrowsingBooks
    {
        private static bool haveBooks;
        private static string wantMoreBooks;
        private static string bookTitleForSearch = Console.ReadLine();
        private static string inWarehouse = "";

        private static void BrowsingForBooks(string bookTitle)
        {
            for (int i = 0; i < AspectsOfBooks.Titles.bookTitle.Length; i++)
            {
                if (bookTitle == AspectsOfBooks.Titles.bookTitle[i])
                {
                    haveBooks = true;

                    Console.WriteLine();
                    Console.WriteLine("Books found:");
                    Console.WriteLine();
                    Console.WriteLine("Book title: " + AspectsOfBooks.Titles.bookTitle[i]);
                    Console.WriteLine("Book author: " + AspectsOfBooks.Authors.bookAuthor[i]);
                    Console.WriteLine("Genre: " + AspectsOfBooks.Genres.bookGenre[i]);
                    Console.WriteLine("Price of the book: " + AspectsOfBooks.Prices.bookPrice[i]);

                    if (AspectsOfBooks.Stock.inStock[i] == "true")
                    {
                        inWarehouse = "Yes!";
                    }
                    else
                    {
                        inWarehouse = "No!";
                    }
                    Console.WriteLine("In stock: " + inWarehouse);
                    break;
                }
                else if (bookTitle != AspectsOfBooks.Titles.bookTitle[i])
                {
                    haveBooks = false;
                }
            }
            if (haveBooks)
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to search for another book?");
                Console.WriteLine("If YES type - Yes");
                Console.WriteLine("If NO type - No");

                wantMoreBooks = Console.ReadLine();

                if (wantMoreBooks.ToLower() == "yes")
                {
                    Console.WriteLine("Please enter another book title:");
                    bookTitleForSearch = Console.ReadLine();
                    SearchForBookByTitle();
                }
                else
                {
                    return;
                }
            }
            else if (!haveBooks)
            {
                Console.WriteLine("We dont have this book in our store. Please enter another.");
                Console.WriteLine();
                Console.WriteLine("Please enter book title:");
                bookTitleForSearch = Console.ReadLine();
                SearchForBookByTitle();
            }
        }

        internal static void SearchForBookByTitle()
        {
            BrowsingForBooks(bookTitleForSearch);
        }
    }
}
