namespace IntergenicResearchLib
{
    public class Book
    {
        public string BookName { get; set; }
        public string BookId { get; set; }

        public Book(string bookName, string bookId)
        {
            BookName = bookName;
            BookId = bookId;
        }
        public override string ToString()
        {
            return $"Book name: {BookName}\nBook Id: {BookId}";
        } 
    }
}