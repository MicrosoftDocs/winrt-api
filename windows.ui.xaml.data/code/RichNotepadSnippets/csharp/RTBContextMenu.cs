using System;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Ink;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media.Effects;
using Windows.UI.Xaml.Media.Imaging;

namespace RichNotepad
{
    //Derives from the abstract class ContextMenu that provides the boilerplate code for displaying a popup window. 

    public class RTBContextMenu : ContextMenu
    {
        RichTextBox rtb;

        public RTBContextMenu(RichTextBox rtb)
        {
            this.rtb = rtb;
        }

        //<SnippetGetContent2>
        //Construct the context menu and return the parent FrameworkElement. 
        protected override FrameworkElement GetContent()
        {
            Border border = new Border() { BorderBrush = new SolidColorBrush(Color.FromArgb(255, 167,171,176)), BorderThickness = new Thickness(1), Background = new SolidColorBrush(Colors.White) };
            border.Effect = new DropShadowEffect() { BlurRadius = 3, Color = Color.FromArgb(255, 230, 227, 236) };

            Grid grid = new Grid() { Margin = new Thickness(1) };
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(25) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(105) });

            grid.Children.Add(new Rectangle() { Fill = new SolidColorBrush(Color.FromArgb(255, 233, 238, 238)) });
            grid.Children.Add(new Rectangle() { Fill = new SolidColorBrush(Color.FromArgb(255, 226, 228, 231)), HorizontalAlignment = HorizontalAlignment.Right, Width = 1 });
            
            //cut
            Button cutButton = new Button() { Height = 22, Margin = new Thickness(0, 0, 0, 0), HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Top, HorizontalContentAlignment = HorizontalAlignment.Left };
            cutButton.Style = Application.Current.Resources["ContextMenuButton"] as Style;
            cutButton.Click += cut_PointerReleased;
            Grid.SetColumnSpan(cutButton, 2);

            StackPanel sp = new StackPanel() { Orientation = Orientation.Horizontal };

            Image cutImage = new Image() { HorizontalAlignment = HorizontalAlignment.Left, Width = 16, Height = 16, Margin = new Thickness(1, 0, 0, 0) };
            cutImage.Source = new BitmapImage(new Uri("/RichNotepad;component/images/cut.png", UriKind.RelativeOrAbsolute));
            sp.Children.Add(cutImage);

            TextBlock cutText = new TextBlock() { Text = "Cut", HorizontalAlignment = HorizontalAlignment.Left, Margin = new Thickness(16, 0, 0, 0) };
            sp.Children.Add(cutText);

            cutButton.Content = sp;

            grid.Children.Add(cutButton);

            //copy
            Button copyButton = new Button() { Height = 22, Margin = new Thickness(0, 24, 0, 0), HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Top, HorizontalContentAlignment = HorizontalAlignment.Left };
            copyButton.Style = Application.Current.Resources["ContextMenuButton"] as Style;
            copyButton.Click += copy_PointerReleased;
            Grid.SetColumnSpan(copyButton, 2);

            sp = new StackPanel() { Orientation = Orientation.Horizontal };

            Image copyImage = new Image() { HorizontalAlignment = HorizontalAlignment.Left, Width = 16, Height = 16, Margin = new Thickness(1, 0, 0, 0) };
            copyImage.Source = new BitmapImage(new Uri("/RichNotepad;component/images/copy.png", UriKind.RelativeOrAbsolute));
            sp.Children.Add(copyImage);

            TextBlock copyText = new TextBlock() { Text = "Copy", HorizontalAlignment = HorizontalAlignment.Left, Margin = new Thickness(16, 0, 0, 0) };
            sp.Children.Add(copyText);

            copyButton.Content = sp;

            grid.Children.Add(copyButton);          

            //paste
            Button pasteButton = new Button() { Height = 22, Margin = new Thickness(0, 48, 0, 0), HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Top, HorizontalContentAlignment = HorizontalAlignment.Left };
            pasteButton.Style = Application.Current.Resources["ContextMenuButton"] as Style;
            pasteButton.Click += paste_PointerReleased;
            Grid.SetColumnSpan(pasteButton, 2);

            sp = new StackPanel() { Orientation = Orientation.Horizontal };

            Image pasteImage = new Image() { HorizontalAlignment = HorizontalAlignment.Left, Width = 16, Height = 16, Margin = new Thickness(1, 0, 0, 0) };
            pasteImage.Source = new BitmapImage(new Uri("/RichNotepad;component/images/paste.png", UriKind.RelativeOrAbsolute));
            sp.Children.Add(pasteImage);

            TextBlock pasteText = new TextBlock() { Text = "Paste", HorizontalAlignment = HorizontalAlignment.Left, Margin = new Thickness(16, 0, 0, 0) };
            sp.Children.Add(pasteText);

            pasteButton.Content = sp;

            grid.Children.Add(pasteButton);

            border.Child = grid;

            return border;
        }
        //</SnippetGetContent2>

        //<SnippetCutCopyPaste>
        //handle the cut, copy and paste actions when the appropriate button on the context menu is clicked. 
        void cut_PointerReleased(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(rtb.Selection.Text);
            rtb.Selection.Text = "";
            Close();
        }

        void copy_PointerReleased(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(rtb.Selection.Text);
            Close();
        }

        void paste_PointerReleased(object sender, RoutedEventArgs e)
        {
            rtb.Selection.Text = Clipboard.GetText();
            Close();
        }
        //</SnippetCutCopyPaste>
    }
}
