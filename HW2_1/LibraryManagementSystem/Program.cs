namespace LibraryManagementSystem
{
    internal class Program
    {
        private static List<Book> Books = new List<Book>();
        private static List<User> Users = new List<User>();

        static void Main(string[] args)
        {
            Console.WriteLine("This is a Library management system.");
            for (int i = 0; i < "This is a Library management system.".Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Choose an option: ");

                Console.WriteLine("1. Add a user");
                Console.WriteLine("2. Add a book");
                Console.WriteLine("3. A user wants to borrow a book");
                Console.WriteLine("4. A user wants to return a borrowed book");
                Console.WriteLine("5. See the books list");
                Console.WriteLine("6. See the users list");
                Console.WriteLine("0. Exit");
                Console.Write("Option number: ");

                int option = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (option == 0)
                    break;
                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Please enter the user ID: ");
                            int userid = int.Parse(Console.ReadLine());

                            Console.Write("Please enter the user's name: ");
                            string username = Console.ReadLine();

                            Users.Add(new User(userid, username));

                            break;
                        }
                    case 2:
                        {
                            Console.Write("Please enter the book's title: ");
                            string title = Console.ReadLine();

                            Console.Write("Please enter the book's ID: ");
                            int id = int.Parse(Console.ReadLine());

                            Console.Write("Please enter the book's author: ");
                            string author = Console.ReadLine();

                            Books.Add(new Book(id, title, author, true));

                            break;
                        }
                    case 3:
                        {
                            Console.Write("Please enter the user's ID: ");
                            int userid = int.Parse(Console.ReadLine());

                            Console.Write("Please enter the book's ID: ");
                            int bookid = int.Parse(Console.ReadLine());

                            if (BorrowBook(userid, bookid))
                            {
                                Console.WriteLine("Done.\n");
                            }
                            else
                            {
                                Console.WriteLine("Try again.\n");
                                Console.WriteLine("* * *\n");
                                continue;
                            }

                            Console.WriteLine();

                            break;
                        }
                    case 4:
                        {
                            Console.Write("Please enter the user's ID: ");
                            int userid = int.Parse(Console.ReadLine());

                            Console.Write("Please enter the book's ID: ");
                            int bookid = int.Parse(Console.ReadLine());

                            if (ReturnBook(userid, bookid))
                            {
                                Console.WriteLine("Done.\n");
                            }
                            else
                            {
                                Console.WriteLine("Try again.\n");
                                Console.WriteLine("* * *\n");
                                continue;
                            }

                            Console.WriteLine();

                            break;
                        }
                    case 5:
                        {
                            if (!Books.Any())
                            {
                                Console.WriteLine("The list is empty!\n");
                                break;
                            }

                            Console.WriteLine("Title\t\tID");
                            foreach (var item in  Books)
                            {
                                Console.Write(item.Title + "\t\t" + item.Id);
                            }

                            Console.WriteLine();

                            break;
                        }
                    case 6:
                        {
                            if (!Users.Any())
                            {
                                Console.WriteLine("The list is empty!\n");
                                break;
                            }

                            Console.WriteLine("User Name\t\tID");
                            foreach (var item in Users)
                            {
                                Console.WriteLine(item.UserName + "\t\t" + item.UserId);
                            }

                            Console.WriteLine();

                            break;
                        }
                }
                Console.WriteLine("* * *\n");
            }

            Console.WriteLine("Enter any key to close the window...");
            Console.ReadKey();
        }

        private static bool BorrowBook(int userId, int bookId)
        {
            var findUser =
                from user in Users
                where user.UserId == userId
                select user;

            var findBook =
                from book in Books
                where book.Id == bookId
                select book;

            if (!findBook.Any())
            {
                throw new BookNotFoundException("Error: There is no such book!");
                return false;
            }

            foreach (User user in findUser)
            {
                foreach (Book book in findBook)
                {
                    if (book.IsAvailable ==  false)
                    {
                        throw new BookNotAvailableException("Error: Book is not available!");
                        return false;
                    }
                    user.BorrowedBooksIds.Add(book.Id);
                    book.IsAvailable = false;
                }
            }

            return true;
        }

        private static bool ReturnBook(int userId, int bookId)
        {
            var findUser =
                from user in Users
                where user.UserId == userId
                select user;

            var findBook =
                from book in Books
                where book.Id == bookId
                select book;

            if (!findBook.Any())
            {
                throw new BookNotFoundException("Error: There is no such book!");
                return false;
            }

            foreach (User user in findUser)
            {
                foreach (Book book in findBook)
                {
                    user.BorrowedBooksIds.Remove(book.Id);
                    book.IsAvailable = true;
                }
            }

            return true;
        }
    }
}
