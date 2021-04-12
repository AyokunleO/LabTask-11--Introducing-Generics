using System;
namespace IntergenicResearchLib
{
    public class Library : IDefaulterList
    {
        public string Name { get; set; }
        private int year;
        public Book BookInfo { get; set; }

        public DateTime DateIssue { get; set; }
        public DateTime DateReturn { get; set; }

        public Library(string name, int year, Book bookInfo, DateTime dateIssue, DateTime dateReturn)
        {
            Name = name;
            Year = year;
            BookInfo = bookInfo;
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
        public Book GetBook()
        {
            return BookInfo;
        }
        public DateTime GetDateIssue()
        {
            return DateIssue;
        }
        public DateTime GetDateReturn()
        {
            return DateReturn;
        }
        public string GetDefaulter()
        {
            if(DateReturn.Subtract(DateIssue) >  new TimeSpan(3,0,0,0))
            {
                return $"Student's name: {Name}\nBook Info: {BookInfo}";
            }else{
                return $"No defaulter at the moment";
            }
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
            return $"{Name}, {Year}, {BookInfo}, {DateIssue}, {DateReturn}\n";
        }

        
    }
}