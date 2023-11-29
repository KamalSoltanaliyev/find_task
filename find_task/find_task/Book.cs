namespace find_task
{
    public class Book
    {
        public string Name { get; }
        public string AuthorName { get; }
        public int PageCount { get; }
        public bool IsDeleted { get; private set; }

        //public Book( string name, string authorName, int pageCount)
        //{
        //    Name = name;
        //    AuthorName = authorName;
        //    PageCount = pageCount;
        //    IsDeleted = false;
        //}

        public void ShowInfo()
        {
            Console.WriteLine($" Name: {Name}, Author: {AuthorName}, Page Count: {PageCount}, IsDeleted: {IsDeleted}");
        }
    }
}
