//<Snippet10_CS>
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
//using System.Collections.ObjectModel;
using Windows.UI.Xaml.Data;
using System.Collections.ObjectModel;

namespace ListBoxSnippetEx
{
    public partial class Page : UserControl
    {
        public Page()
        {
            // Required to initialize variables
            InitializeComponent();
        }

        //<Snippet111_CS>
        void PrintText(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            textBlock1.Text = "   You selected " + lbi.Content.ToString() + ".";
        }
        //</Snippet111_CS>

    }

    //<Snippet101_CS>
    public class Customer
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }

        public Customer(String firstName, String lastName, String address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }

    }

    public class Customers : ObservableCollection<Customer>
    {
        public Customers()
        {
            Add(new Customer("Michael", "Anderberg",
                    "12 North Third Street, Apartment 45"));
            Add(new Customer("Chris", "Ashton",
                    "34 West Fifth Street, Apartment 67"));
            Add(new Customer("Seo-yun", "Jun",
                    "56 East Seventh Street, Apartment 89"));
            Add(new Customer("Guido", "Pica",
                    "78 South Ninth Street, Apartment 10"));
        }

    }
    //</Snippet101_CS>
}
// </Snippet10_CS>