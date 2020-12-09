using System;
using System.Globalization;
namespace RentalApp
{
internal class Rental
{
public Book Book;
public DateTime DateRented;
public DateTime DateDue;
public Rental(Book book, DateTime dateDue)
{

DateRented = DateTime.Today;

DateDue = dateDue;

}

}

}