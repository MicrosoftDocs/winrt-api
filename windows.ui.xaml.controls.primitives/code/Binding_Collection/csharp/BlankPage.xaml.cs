using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Binding_Collection
{
    public sealed partial class BlankPage : Page
    {
        Bills MyBills;

        public BlankPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void LoadedHandler(object sender, RoutedEventArgs e)
        {
            MyBills = new Bills();
            DataContext = MyBills.GetStatements();
        }

        public class Statements : INotifyPropertyChanged
        {
            private DateTime _Month;
            private double _Total;

            #region INotifyPropertyChanged Members

            public event PropertyChangedEventHandler PropertyChanged;

            #endregion

            public DateTime Month
            {
                get { return _Month; }
                set
                {
                    _Month = value;
                    NotifyPropertyChanged("Month");
                }
            }
            public double Total
            {
                get { return _Total; }
                set
                {
                    _Total = value;
                    NotifyPropertyChanged("Total");
                }
            }
            public Statements(DateTime month, double total)
            {
                this.Month = month;
                this.Total = total;
            }

            public void NotifyPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }

        public class Bills
        {
            private ObservableCollection<Statements> _AllStatements;

            public ObservableCollection<Statements> AllStatements
            {
                get
                {
                    if (_AllStatements == null)
                    {
                        _AllStatements = new ObservableCollection<Statements>();
                    }
                    return _AllStatements;
                }
            }

            public ObservableCollection<Statements> GetStatements()
            {
                if (_AllStatements == null)
                {
                    _AllStatements = new ObservableCollection<Statements>();
                }
                DateTime dt = new DateTime(2007, 1, 1);
                double amt = 1242.54;
                _AllStatements.Add(new Statements(dt, amt));
                _AllStatements.Add(new Statements(new DateTime(2007, 2, 1), 435.98));
                return _AllStatements;
            }
        }
    }
}
