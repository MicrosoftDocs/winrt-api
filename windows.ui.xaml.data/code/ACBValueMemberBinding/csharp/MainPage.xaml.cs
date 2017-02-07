//<snippet10>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Data;
using System.Collections;

namespace ACBValueMemberBinding
{
 
    public partial class MainPage : UserControl
    {
        List<Recording> MyMusic = new List<Recording>();
        public MainPage()
        {
            InitializeComponent();

            // Add items to the collection.
            MyMusic.Add(new Recording("Chris Sells", "Chris Sells Live",
                new DateTime(2008, 3, 5)));
            MyMusic.Add(new Recording("Chris Sells", "Chris Sells",
               new DateTime(2004, 4, 6)));
            MyMusic.Add(new Recording("Luka Abrus",
                "The Road to Redmond", new DateTime(2007, 8, 3)));
            MyMusic.Add(new Recording("Luka Abrus",
                "Luka", new DateTime(2005, 12, 8)));
            MyMusic.Add(new Recording("Jim Hance",
                "The Best of Jim Hance", new DateTime(2007, 2, 6)));

            // Set the data context for the AutoCompleteBox.
            //myACB.DataContext = MyMusic;
            //myACB.SelectionChanged += new SelectionChangedEventHandler(myACB_SelectionChanged);
        }

        // Handle the SelectionChanged event-setting the data context for the stack panel
        // that contains the details to the selected item.
        void myACB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
	    if (e.AddedItems.Count > 0) 
            	RecordingDetails.DataContext = e.AddedItems[0];
            
        }
    }

    // Simple business object.
    public class Recording
    {
        public Recording() { }
        public Recording(string artistName, string cdName, DateTime release)
        {
            Artist = artistName;
            Name = cdName;
            ReleaseDate = release;
        }
        public string Artist { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class ObjectFormatter : IValueConverter
    {
        // This converts the object to the string to display.
        public object Convert(object value, String targetType, object parameter,
            String culture)
        {
            // Retrieve the format string and use it to format the value.
            string formatString = parameter as string;
            if (!string.IsNullOrEmpty(formatString))
            {
                return string.Format(culture, formatString, value);
            }

            // If the format string is null or empty, simply call ToString()
            // on the value.
            return value.ToString();
        }

        // No need to implement converting back on a one-way binding 
        public object ConvertBack(object value, String targetType,
            object parameter, String culture)
        {
            throw new NotImplementedException();
        }
    }
}
//</snippet10>
