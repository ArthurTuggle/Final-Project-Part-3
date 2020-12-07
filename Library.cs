using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class LibraryCollection
    {
        private List<Patron> PatronList; 
        List<Book> BookList; 


        public void AddPatron(Patron patron)
        {
            this.PatronList.Add(patron); 
           
            
            Console.WriteLine("Added Patron Succesfully" + patron.getFirstName()+" "+patron.getLastName() );

        }

        public void RemovePatron(Patron patron)
        {
            this.PatronList.Remove(patron); 


            Console.WriteLine("Removed Patron Object " + patron.getFirstName() + " " + patron.getLastName()); 
        }

        public void DisplayPatronInfo()
        {
            foreach(Patron patron in this.PatronList)
            {

                

            }
        }
        public void AddToCollection(Book book)
        {
            this.BookList.Add(book);
            Console.WriteLine("Added Book Sucessfully!");

        }

        public void RemoveFromCollection(Book book)
        {
            this.BookList.Remove(book);
            Console.WriteLine("Removed Book Sucessfully!");
        }

        public void DisplayCollection()
        {
            foreach(Book book in this.BookList)
            {
                book.Display();
            }
        }

        public void ProcessRental(Patron patron)
        {
                    
        }

        public void ProcessReturns(Patron patron,Book book)
        {
            
        }


    }
}