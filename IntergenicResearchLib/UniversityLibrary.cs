using System;

namespace IntergenicResearchLib
{
    class UniversityLibrary
    {
        static void Main(string[] args)
        {
            // (2021,5,4)
            // (2021,5,7)
            GenericDefaulterList<IDefaulterList> info = new GenericDefaulterList<IDefaulterList>();

            var stud = new Library("David Busting", 2021, new Book("Movement of the Blacks", "B567423"), new DateTime(2021,5,4), new DateTime(2021,5,7).AddDays(3));
            var stud2 = new Library("David Bust", 2021, new Book("Movement of the Whites", "B566623"), new DateTime(2021,5,4), new DateTime(2021,5,7));

            info.Add(stud);
            info.Add(stud2);

            info.PrintDef();
        }
    }
}
