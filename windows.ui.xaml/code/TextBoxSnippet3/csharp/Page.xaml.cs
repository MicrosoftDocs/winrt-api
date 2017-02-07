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

namespace TextBoxSnippet3
{
    public partial class Page : UserControl
    {
        //<SnippetScrollBarCode>
        public Page()
        {
            InitializeComponent();
            CreateControls();
        }

        private void CreateControls()
        {
            //Create stack panel
            StackPanel MyStackPanel = new StackPanel();

            //Create the first text box
            TextBox MyTB1 = new TextBox();
            MyTB1.Width = 300;
            MyTB1.Height = 50;
            MyTB1.Text = "A text box that demonstrates TextWrapping, TextAlignment, MaxLength and AcceptsReturn";
            MyTB1.TextWrapping = TextWrapping.Wrap;
            MyTB1.TextAlignment = TextAlignment.Center;
            MyTB1.MaxLength = 500;
            MyTB1.AcceptsReturn = true;
            MyTB1.Margin = new Thickness(20, 20, 0, 0);


            //Add the text boxes to the stack panel
            MyStackPanel.Children.Add(MyTB1);

            this.Content = MyStackPanel;
        }
        //</SnippetScrollBarCode>
            // REMOVED/MOVED CODE
            //ScrollBar visibility cannot be affected for a TB even if using a scrollviewer host set
            //so taking this out of the snippet to avoid any misconceptions
            //Create the second text box
            //TextBox MyTB2 = new TextBox();
            //MyTB2.Margin = new Thickness(20, 20, 0, 0);
            //MyTB2.Text = "A text box that demonstrates HorizontalScrollBarVisibility and VerticalScrollBarVisibility";
            //MyTB2.Width = 300;
            //MyTB2.Height = 50;
            //MyTB2.AcceptsReturn = true;
            //ScrollViewer.SetHorizontalScrollBarVisibility(MyTB2,ScrollBarVisibility.Visible);
            //ScrollViewer.SetVerticalScrollBarVisibility(MyTB2, ScrollBarVisibility.Visible);

            //MyStackPanel.Children.Add(MyTB2);
    }
}
