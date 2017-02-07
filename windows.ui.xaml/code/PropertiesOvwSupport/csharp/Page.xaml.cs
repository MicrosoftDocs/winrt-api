using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using DPO;

namespace PropertiesOvwSupport
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        Application myapp = Application.Current;
        void ToOne(object sender, RoutedEventArgs e) {
            this.LayoutRoot.Children[0] = new Page1();
            this.UpdateLayout();
        }
        void ToTwo(object sender, RoutedEventArgs e)
        {
            //this.LayoutRoot.Children[0] = new Page2();
        }
        void ToThree(object sender, RoutedEventArgs e)
        {
            this.LayoutRoot.Children[0] = new Page3();
            this.UpdateLayout();
        }
        void ToFour(object sender, RoutedEventArgs e)
        {
            this.LayoutRoot.Children[0] = new SilverlightExampleClass();
            this.UpdateLayout();
        }
        void ToFive(object sender, RoutedEventArgs e)
        {
            this.LayoutRoot.Children[0] = new AquariumLibrary.SilverlightExampleClass();
            this.UpdateLayout();
        }
    }
}
