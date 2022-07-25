---
-api-id: T:Windows.UI.Xaml.Data.PropertyChangedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void PropertyChangedEventHandler(System.Object sender, Windows.UI.Xaml.Data.PropertyChangedEventArgs e)
-->
# Windows.UI.Xaml.Data.PropertyChangedEventHandler

## -description
Represents the method that will handle the [PropertyChanged](inotifypropertychanged_propertychanged.md) event. When programming with Microsoft .NET this delegate is hidden, use the [System.ComponentModel.PropertyChangedEventHandler](/dotnet/api/system.componentmodel.propertychangedeventhandler?view=dotnet-uwp-10.0&preserve-view=true) delegate.



## -parameters
### -param sender
The source of the event.

### -param e
Event data.


## -remarks
When programming with Microsoft .NET, this delegate is hidden. Microsoft .NET Developers should use the [System.ComponentModel.PropertyChangedEventHandler](/dotnet/api/system.componentmodel.propertychangedeventhandler?view=dotnet-uwp-10.0&preserve-view=true) delegate.

## -examples
This example demonstrates how to implement the [INotifyPropertyChanged](inotifypropertychanged.md) interface and use PropertyChangedEventHandler. For the complete code listing, see the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind).

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Employee : INotifyPropertyChanged 
    {
        private string _name;
        private string _organization;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        public string Organization
        {
            get { return _organization; }
            set
            {
                _organization = value;
                RaisePropertyChanged("Organization");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

```



## -see-also
[Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
