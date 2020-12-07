using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryCollection collection = new LibraryCollection();

            Patron p1 = new Patron("Tim", "Smith", "1111");
            Patron p2 = new Patron("Connor", "Walsh", "2222");
            Patron p3 = new Patron("Ken", "Adams", "3333");
            Patron p4 = new Patron("Cisco", "Ramon", "4444");
            Patron p5 = new Patron("Oliver", "Queen", "5555");

            collection.AddPatron(p1);
            collection.AddPatron(p2);
            collection.AddPatron(p3);
            collection.AddPatron(p4);
            collection.AddPatron(p5);

            collection.RemovePatron(p5);

            collection.DisplayPatronInfo();

            

            collection.DisplayCollection();
            

            collection.DisplayCollection();

            

            collection.DisplayCollection();

            collection.ProcessRental(p1);

            collection.DisplayCollection();
            


        }
    }
}