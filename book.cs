using System;
using System.Collections.Generic;
using System.Text;

namespace RentalApp
{
    internal class Book
    {
        public int BookId;
        public string BookName;
        public Book(int bookId, string bookName)
        {
            BookId = bookId;
            BookName = bookName;
        }
    }
}