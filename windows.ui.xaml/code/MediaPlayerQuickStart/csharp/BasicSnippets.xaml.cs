using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MediaPlayerQuickStart
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BasicSnippets : Page
    {
        public BasicSnippets()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        //public class MediaMaxvalueToString : IValueConverter
        //{
        //    public object Convert(
        //        object value, Type targetType, object parameter, string language)
        //    {
        //        Duration duration = (Duration)value;

        //        return (int)Math.Round(
        //            duration.TimeSpan.TotalSeconds, MidpointRounding.AwayFromZero);
        //    }

        //    public object ConvertBack(
        //        object value, Type targetType, object parameter, string language)
        //    {
        //        // Not implemented as there is no two-binding used for Slider StepFrequency 
        //        // in this scenario.
        //        return 0.0;
        //    }
        //}
    }
}
