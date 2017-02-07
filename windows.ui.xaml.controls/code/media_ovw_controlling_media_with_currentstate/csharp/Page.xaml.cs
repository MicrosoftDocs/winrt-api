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

namespace media_ovw_controlling_media
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <Snippetmedia_ovw_controlling_media_with_currentstate_code>
        private void StopMedia(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }
        private void PauseMedia(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }
        private void PlayMedia(object sender, RoutedEventArgs e)
        {
            media.Play();
        }
        private void Media_State_Changed(object sender, RoutedEventArgs e)
        {
            mediaStateTextBlock.Text = media.CurrentState.ToString();
        }
        // </Snippetmedia_ovw_controlling_media_with_currentstate_code>
    }
}
