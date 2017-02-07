//<snippet2>
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace ConverterParameterEx
{
    public partial class Page : UserControl
    {

        public ObservableCollection<Recording> MyMusic =
            new ObservableCollection<Recording>();
        public Page()
        {
            InitializeComponent();

            // Add items to the collection.
            MyMusic.Add(new Recording("Chris Sells", "Chris Sells Live",
                new DateTime(2008, 2, 5)));
            MyMusic.Add(new Recording("Luka Abrus",
                "The Road to Redmond", new DateTime(2007, 4, 3)));
            MyMusic.Add(new Recording("Jim Hance",
                "The Best of Jim Hance", new DateTime(2007, 2, 6)));

            // Set the data context for the combo box.
            MusicCombo.DataContext = MyMusic;
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

    public class DateFormatter : IValueConverter
    {
        // This converts the DateTime object to the string to display.
        public object Convert(object value, Type targetType, 
            object parameter, string language)
        {
            // Retrieve the format string and use it to format the value.
            string formatString = parameter as string;
            if (!string.IsNullOrEmpty(formatString))
            {
                return string.Format(
                    new CultureInfo(language), formatString, value);
            }
            // If the format string is null or empty, simply call ToString()
            // on the value.
            return value.ToString();
        }

        // No need to implement converting back on a one-way binding 
        public object ConvertBack(object value, Type targetType, 
            object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
//</snippet2>

