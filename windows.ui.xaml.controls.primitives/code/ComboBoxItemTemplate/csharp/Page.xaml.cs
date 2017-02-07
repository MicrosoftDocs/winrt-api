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
using System.Collections.ObjectModel;

namespace ComboBoxWithTemplate
{
    //<snippet2>
    public partial class Page : UserControl
    {
        public ObservableCollection<Recording> MyMusic = new ObservableCollection<Recording>();
        public Page()
        {
            InitializeComponent();
            MyMusic.Add(new Recording("Sheryl Crow", "Detours", new DateTime(2008, 2, 5)));
            MyMusic.Add(new Recording("Brandi Carlisle", "The Story", new DateTime(2007, 4,3)));
            MyMusic.Add(new Recording("Patty Griffin", "Children Running Through", new DateTime( 2007, 2, 6)));
            MusicCombo.DataContext = MyMusic;
        }
    }

    public class Recording
    {
        public Recording(){}
        public Recording (string artistName, string cdName, DateTime release)
        {
            Artist = artistName;
            Name = cdName;
            ReleaseDate = release;
        }
        public string Artist { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate {get; set;}
    }
    //</snippet2>
    
}
