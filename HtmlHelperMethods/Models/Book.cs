using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace HtmlHelperMethods.Models
{

    public class Books
    {
        public List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "What about Bob", CopiesSold = 4, YearPublished = 2010, Price = 20, InStock = true, Availability = Availability.Pickup });


            return books;
        }
    }

    public class Book 
    { 
        public int BookId { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public int CopiesSold { get; set; }
        public decimal Price {  get; set; }
        public bool InStock     { get; set; }
        public Availability Availability { get; set; }        
        public string Category { get; set; }

        [Required]
        public Genre ? Genre { get; set; }
        public string Description { get; set; }
    }


    // I have to set SciFi =1 so that it shows up correctly on the for
    // See HTml.DropDpwnListForEnum
    // If you need it to be 0 then you need to
    // change the property to nullable
    // public Genre? Genre {get; set;}
    // Then you could apply the [Required] attribute

    public enum Genre
    {
        SciFi,
        Western,
        Technincal,
        Biography
    }

    public enum Availability
    {
        Pickup,
        Delivery,
        Reseller
    }

}