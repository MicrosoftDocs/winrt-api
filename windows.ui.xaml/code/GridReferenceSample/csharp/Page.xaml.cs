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

namespace GridReferenceSample
{
    public partial class Page : UserControl
    {
        //<SnippetGridClassCode>
        public Page()
        {
            InitializeComponent();
            LayoutDesign();
        }

        private void LayoutDesign()
        {
            //Create Stackpanel for ListBox Control and its description
            StackPanel DeptStackPanel = new StackPanel();
            DeptStackPanel.Margin = new Thickness(10);

            LayoutRoot.Children.Add(DeptStackPanel);
            Grid.SetColumn(DeptStackPanel, 1);
            Grid.SetRow(DeptStackPanel, 1);

            TextBlock DeptListHeading = new TextBlock();
            DeptListHeading.Text = "Department";

            ListBox DeptList = new ListBox();
            DeptList.Items.Add("Finance");
            DeptList.Items.Add("Marketing");
            DeptList.Items.Add("Human Resources");
            DeptList.Items.Add("Payroll");

            DeptStackPanel.Children.Add(DeptListHeading);
            DeptStackPanel.Children.Add(DeptList);

            //Create StackPanel for buttons
            StackPanel ButtonsStackPanel = new StackPanel();
            ButtonsStackPanel.Margin = new Thickness(10);
            ButtonsStackPanel.Orientation = Orientation.Horizontal;
            ButtonsStackPanel.HorizontalAlignment = HorizontalAlignment.Center;

            LayoutRoot.Children.Add(ButtonsStackPanel);
            Grid.SetColumn(ButtonsStackPanel, 0);
            Grid.SetRow(ButtonsStackPanel, 2);
            Grid.SetColumnSpan(ButtonsStackPanel, 2);

            Button BackButton = new Button();
            BackButton.Content = "Back";
            BackButton.Width = 100;

            Button CancelButton = new Button();
            CancelButton.Content = "Cancel";
            CancelButton.Width = 100;

            Button NextButton = new Button();
            NextButton.Content = "Next";
            NextButton.Width = 100;

            ButtonsStackPanel.Children.Add(BackButton);
            ButtonsStackPanel.Children.Add(CancelButton);
            ButtonsStackPanel.Children.Add(NextButton);

            BackButton.Margin = new Thickness(10);
            CancelButton.Margin = new Thickness(10);
            NextButton.Margin = new Thickness(10);
        }
    }
    //</SnippetGridClassCode>
}
