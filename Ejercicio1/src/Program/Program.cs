using System;

namespace SRP
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>(values);
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");
            ShelveBook shelve1 = new ShelveBook("A", "7", book1);
            Console.WriteLine(shelve1.Book.Title);
        }
    }
}