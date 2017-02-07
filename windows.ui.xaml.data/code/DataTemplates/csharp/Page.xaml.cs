using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace DataTemplates
{
    public partial class Page : UserControl
    {
        ObservableCollection<Thing> MyThings;
        public Page()
        {
            InitializeComponent();

            //<Snippet2>
            // Create the collection.
            MyThings = new ObservableCollection<Thing>();

            //Create each object in the collection
            Thing flower = new Thing("Flower", "flower.jpg");
            Thing snake = new Thing("Snake", "snake.jpg");
            Thing sunset = new Thing("Sunset", "sunset.jpg");

            // Add the objects to the collection.
            MyThings.Add(flower);
            MyThings.Add(snake);
            MyThings.Add(sunset);
            //</Snippet2>

            //<Snippet5>
            // LayoutRoot is the name of the root Grid.
            LayoutRoot.DataContext = MyThings;
            //</Snippet5>
        }

        
    }

    //<Snippet1>
    public class Thing
    {
        public Thing(string title, string imageUri)
        {
            this.Title = title;
            this.Photo = imageUri;
        }

        public string Photo { get; set; }
        public string Title { get; set; }
        
    }
    //</Snippet1>
}
