using System;
namespace IntergenicResearchLib
{
    public class Library : IDefaulterList
    {
        public string Name { get; set; }
        private int year;
        public string BookName { get; set; }
        public string BookId { get; set; }
        public Date DateIssue { get; set; }
        public Date DateReturn { get; set; }

        public Library(string name, int year, string bookName, string bookId, Date dateIssue, Date dateReturn)
        {
            Name = name;
            Year = year;
            BookName = bookName;
            BookId = bookId;
            DateIssue = dateIssue;
            DateReturn = dateReturn;
        }

        public string GetName()
        {
            return Name;
        }
        public int GetYear()
        {
            return Year;
        }
        public string GetBook()
        {
            return BookName;
        }
        public Date GetDateIssue()
        {
            return DateIssue;
        }
        public Date GetDateReturn()
        {
            return DateReturn;
        }
        public string GetDefaulter()
        {
            return $"Student's name: {Name}\nBook name: {BookName}\nBook Id: {BookId}";
        }
        public int Year
        {
            get { return year; }
            set { 
                if (value > 0)
                {
                    year = value;
                }
                }
        }

        public override string ToString()
        {
            return $"{Name}, {Year}, {BookName}, {BookId}, {DateIssue}, {DateReturn}\n";
        }

        
    }
}