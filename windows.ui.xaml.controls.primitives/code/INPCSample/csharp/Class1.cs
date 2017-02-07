using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//<Snippet1>
//Add using statements
using Windows.Foundation;
using Windows.UI.Xaml.Data;
//</Snippet1>
namespace INPCSample
{
    //<Snippet2>
    // Create a class that implements INotifyPropertyChanged
    public class Person : INotifyPropertyChanged
    {
        private string firstNameValue;
        public string FirstName
        {
            get { return firstNameValue; }
            set
            {
                firstNameValue = value;
                // Call NotifyPropertyChanged when the property is updated
                NotifyPropertyChanged("FirstName");
            }
        }

        // Declare the PropertyChanged event
        public event PropertyChangedEventHandler PropertyChanged;

        // NotifyPropertyChanged will raise the PropertyChanged event passing the
        // source property that is being updated.
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    //</Snippet2>
}
