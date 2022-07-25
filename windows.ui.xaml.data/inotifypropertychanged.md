---
-api-id: T:Windows.UI.Xaml.Data.INotifyPropertyChanged
-api-type: winrt interface
---

<!-- Interface syntax.
public interface INotifyPropertyChanged : 
-->

# Windows.UI.Xaml.Data.INotifyPropertyChanged

## -description
Notifies clients that a property value has changed.



> **.NET**
> This interface appears as [System.ComponentModel.INotifyPropertyChanged](/dotnet/api/system.componentmodel.inotifypropertychanged?view=dotnet-uwp-10.0&preserve-view=true).



## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.ComponentModel.INotifyPropertyChanged](/dotnet/api/system.componentmodel.inotifypropertychanged?view=dotnet-uwp-10.0&preserve-view=true) interface.

The INotifyPropertyChanged interface is used to notify clients, typically binding clients, that a property value has changed. For example, consider an `Employee` object with a property called `Name`. To provide generic property-change notification, the `Employee` type implements the INotifyPropertyChanged interface and raises a [PropertyChanged](inotifypropertychanged_propertychanged.md) event when `Name` is changed.

The [PropertyChanged](inotifypropertychanged_propertychanged.md) event can indicate that all properties on the object have changed by using [String.Empty](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) for the [PropertyName](propertychangedeventargs_propertyname.md) property of the [PropertyChangedEventArgs](propertychangedeventargs.md). Note that you cannot use **null** (**Nothing** in Microsoft Visual Basic) for this like you can in Windows Presentation Foundation (WPF) and Microsoft Silverlight.

The [PropertyChanged](inotifypropertychanged_propertychanged.md) event can indicate that indexer properties on the object have changed by using a [PropertyName](propertychangedeventargs_propertyname.md) value of "Item[*indexer* ]" for specific indexers or "Item[]" for all indexers. Note that C++ does not currently support binding to indexers. For a workaround, see the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind).

## -examples

## -see-also
[Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
