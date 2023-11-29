namespace find_task
{
    public class Library
    {
        public int BookLimit { get; private set; }
        public Book[] Books { get; private set; }

        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
            Books = new Book[0];
        }
        //public Book[] GetBooks()
        //{
        //    return Books;
        //}


        public void AddBook(Book newBook, Book[] books)
        {
            if (newBook == null || string.IsNullOrWhiteSpace(newBook.Name) || string.IsNullOrWhiteSpace(newBook.AuthorName) || newBook.PageCount <= 0)
            {
                throw new ArgumentException("Name, AuthorName, and PageCount book yazmaq ucun lazimdi.");
            }

            if (Array.Exists(Books, book => book != null && book.Name.Equals(newBook.Name, StringComparison.OrdinalIgnoreCase) && !book.IsDeleted))
            {
                throw new AlreadyExistsException();
            }

            if (Books.Length >= BookLimit)
            {
                throw new CapacityLimitException();
            }

            Array.Resize(array: ref books, Books.Length + 1);
            Books[Books.Length - 1] = newBook;
        }
        List<Book> library = new List<Book>
        {
            
        };
        private List<Book> books;

        public Library()
        {
            books = new List<Book>
            {

            };     
        }   

        public Book FindBook(Predicate<Book> condition)
        {
            return books.Find(condition);
        }
    }
}

