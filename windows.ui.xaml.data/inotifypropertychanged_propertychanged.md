---
-api-id: E:Windows.UI.Xaml.Data.INotifyPropertyChanged.PropertyChanged
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.UI.Xaml.Data.PropertyChangedEventHandler PropertyChanged
-->

# Windows.UI.Xaml.Data.INotifyPropertyChanged.PropertyChanged

## -description
Occurs when a property value changes.



## -remarks
When building UWP app with the Microsoft .NET Framework, this interface is hidden and developers should use the [System.ComponentModel.INotifyPropertyChanged](/dotnet/api/system.componentmodel.inotifypropertychanged?view=dotnet-uwp-10.0&preserve-view=true) interface.

The PropertyChanged event can indicate that all properties on the object have changed by using [String.Empty](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) for the [PropertyName](propertychangedeventargs_propertyname.md) property of the [PropertyChangedEventArgs](propertychangedeventargs.md). Note that you cannot use **null** for this like you can in Windows Presentation Foundation (WPF) and Microsoft Silverlight.

## -examples
This example demonstrates how to implement the [INotifyPropertyChanged](inotifypropertychanged.md) interface and fire the PropertyChanged event whenever property values change. For the complete code listing, see the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind).

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
