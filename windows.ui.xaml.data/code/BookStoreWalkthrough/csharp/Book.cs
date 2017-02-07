using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;

namespace BookStore
{
    public class Book
    {
        //<snippet1>
        public Book() { }
        

        public Book(string isbn, string title,
            DateTime publishdate, double price)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.PublishDate = publishdate;
            this.Price = price;
        }

        //Define the public properties
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        //</snippet1>
    }
    
}
