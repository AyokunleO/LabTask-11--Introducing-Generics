using System;

namespace IntergenicResearchLib
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDefaulterList<Library> info = new GenericDefaulterList<Library>(2);

            info.Enqueue(new Library("David Busting", 2021, "Movement of the Blacks", "B567423", new Date(4,5,2021), new Date(5,6,2021)));
            info.Enqueue(new Library("David Bust", 2021, "Movement of the Whites", "B566623", new Date(4,5,2022), new Date(5,6,2022)));

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(info.Dequeue());
            }

            
        }
    }
}
