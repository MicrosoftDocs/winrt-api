using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
//<snippet20>
using System.Collections.ObjectModel;
//</snippet20>
//<snippet80>
using Windows.UI.Xaml.Data;
//</snippet80>
namespace BookStore
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            //<snippet4>
            //You can add items to your collection
            AllBooks.Add(new Book("4458907683", "Training Your Dog",
                new DateTime(2000, 2, 8), 44.25));
            AllBooks.Add(new Book("0446675385", "Good Owners, Great Dogs",
                new DateTime(1999, 9, 1), 15.99));
            //Set the data context for the list of books
            MyBooks.DataContext = AllBooks;
     
           //</snippet4>

            //<snippet6>
            this.MyBooks.SelectionChanged +=
                new SelectionChangedEventHandler(MyBooks_SelectionChanged);
            MyBooks.SelectedIndex = 0;
            //</snippet6>
        }
        //Create a collection to store data items
        //<snippet2>
        private ObservableCollection<BookStore.Book> _AllBooks;
        public ObservableCollection<Book> AllBooks
        {
            get
            {
                if (_AllBooks == null)
                {
                    _AllBooks = new ObservableCollection<Book>();
                    _AllBooks.Add(new Book("3390092284", "All About Dogs",
                        new DateTime(2004, 3, 4), 12.99));

                }
                return _AllBooks;
            }
        }

        
        //</snippet2>
        //<snippet7>
        private void MyBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox myBooks = sender as ListBox;
            BookDetails.DataContext = myBooks.SelectedItem;
        }
        //</snippet7>
    }
   
}
