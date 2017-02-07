using System.ComponentModel;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;


namespace Binding_Simple_2
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
            //<SnippetDataContext>
            // Create an instance of the MyColors class 
            // that implements INotifyPropertyChanged.
            MyColors textcolor = new MyColors();

            // Brush1 is set to be a SolidColorBrush with the value Red.
            textcolor.Brush1 = new SolidColorBrush(Colors.Red);

            // Set the DataContext of the TextBox MyTextBox.
            MyTextBox.DataContext = textcolor;
            //</SnippetDataContext>
        }

        //<Snippet1>
        // Create a class that implements INotifyPropertyChanged.
        public class MyColors : INotifyPropertyChanged
        {
            private SolidColorBrush _Brush1;

            // Declare the PropertyChanged event.
            public event PropertyChangedEventHandler PropertyChanged;

            // Create the property that will be the source of the binding.
            public SolidColorBrush Brush1
            {
                get { return _Brush1; }
                set
                {
                    _Brush1 = value;

                    // Call NotifyPropertyChanged when the source property 
                    // is updated.
                    NotifyPropertyChanged("Brush1");
                }
            }

            // NotifyPropertyChanged will raise the PropertyChanged event, 
            // passing the source property that is being updated.
            public void NotifyPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, 
                        new PropertyChangedEventArgs(propertyName));
                }
            }
        }
        //</Snippet1>
    }
}
