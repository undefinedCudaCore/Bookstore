namespace Bookstore.Preferences
{
    internal class SearchingForBooks
    {
        private static string wantMoreBooks;
        private static string wantMoreBooks2;
        private static string bookGenreForSearch = Console.ReadLine();
        private static string inWarehouse = "";
        private static bool haveBooks;

        //private static List<string> bookTitleList = new List<string>();
        //private static List<string> bookAuthorList = new List<string>();
        //private static List<string> bookGenreList = new List<string>();
        //private static List<string> bookPriceList = new List<string>();

        private static void SearchingBooks(string bookGenre)
        {
            for (int i = 0; i < AspectsOfBooks.Genres.bookGenre.Length; i++)
            {
                //bookTitleList.Add(AspectsOfBooks.Titles.bookTitle[i]);
                //bookAuthorList.Add(AspectsOfBooks.Authors.bookAuthor[i]);
                //bookGenreList.Add(AspectsOfBooks.Genres.bookGenre[i]);
                //bookPriceList.Add(AspectsOfBooks.Prices.bookPrice[i]);

                if (bookGenre == AspectsOfBooks.Genres.bookGenre[i])
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
                }
                else if (bookGenre != AspectsOfBooks.Genres.bookGenre[i])
                {
                    haveBooks = false;
                }
            }
            SeachForMoreBooksByStock(bookGenre);
        }

        internal static void SearchForBookByGenre()
        {
            SearchingBooks(bookGenreForSearch);
        }

        internal static void SeachForMoreBooksByGenre()
        {
            for (int j = 0; j < AspectsOfBooks.Genres.bookGenre.Length; j++)
            {
                if (!haveBooks)
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to search for another book?");
                    Console.WriteLine("If YES type - Yes");
                    Console.WriteLine("If NO type - No");
                    Console.WriteLine();

                    wantMoreBooks = Console.ReadLine();

                    if (wantMoreBooks.ToLower() == "yes")
                    {
                        Console.WriteLine("Please enter another book genre:");
                        bookGenreForSearch = Console.ReadLine();
                        SearchForBookByGenre();
                        break;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        internal static void SeachForMoreBooksByStock(string bookGenre)
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to see books in stock?");
            Console.WriteLine("If YES type - Yes");
            Console.WriteLine("If not in stock type - not in stock");
            Console.WriteLine("To continue type - No");
            Console.WriteLine();

            wantMoreBooks2 = Console.ReadLine();

            if (wantMoreBooks2 == "yes")
            {
                for (int i = 0; i < AspectsOfBooks.Genres.bookGenre.Length; i++)
                {
                    if (bookGenre == AspectsOfBooks.Genres.bookGenre[i])
                    {
                        if (AspectsOfBooks.Stock.inStock[i] == "true")
                        {
                            Console.WriteLine();
                            Console.WriteLine("These Books are in stock:");
                            Console.WriteLine();
                            Console.WriteLine("Book title: " + AspectsOfBooks.Titles.bookTitle[i]);
                            Console.WriteLine("Book author: " + AspectsOfBooks.Authors.bookAuthor[i]);
                            Console.WriteLine("Genre: " + AspectsOfBooks.Genres.bookGenre[i]);
                            Console.WriteLine("Price of the book: " + AspectsOfBooks.Prices.bookPrice[i]);
                        }
                    }
                }
                SeachForMoreBooksByGenre();
            }
            else if (wantMoreBooks2 == "not in stock")
            {
                for (int i = 0; i < AspectsOfBooks.Genres.bookGenre.Length; i++)
                {
                    if (bookGenre == AspectsOfBooks.Genres.bookGenre[i])
                    {
                        if (AspectsOfBooks.Stock.inStock[i] != "true")
                        {
                            Console.WriteLine();
                            Console.WriteLine("These Books are NOT in stock:");
                            Console.WriteLine();
                            Console.WriteLine("Book title: " + AspectsOfBooks.Titles.bookTitle[i]);
                            Console.WriteLine("Book author: " + AspectsOfBooks.Authors.bookAuthor[i]);
                            Console.WriteLine("Genre: " + AspectsOfBooks.Genres.bookGenre[i]);
                            Console.WriteLine("Price of the book: " + AspectsOfBooks.Prices.bookPrice[i]);
                        }
                    }
                }
                SeachForMoreBooksByGenre();
            }
            else
            {
                SeachForMoreBooksByGenre();
            }
        }

    }

}
