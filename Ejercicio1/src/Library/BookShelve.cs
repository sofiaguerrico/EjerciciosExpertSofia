using System;

namespace SRP
{
    public class ShelveBook
    {
        public string Sector { get; }
        public string Shelve { get; }
        public Book Book {get;}
        public ShelveBook(string sector, string shelve, Book book){
            this.Sector=sector;
            this.Shelve=shelve;
            this.Book=book;
        }
    }
}