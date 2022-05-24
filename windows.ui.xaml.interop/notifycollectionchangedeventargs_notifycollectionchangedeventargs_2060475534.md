---
-api-id: M:Windows.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.#ctor(Windows.UI.Xaml.Interop.NotifyCollectionChangedAction,Windows.UI.Xaml.Interop.IBindableVector,Windows.UI.Xaml.Interop.IBindableVector,System.Int32,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public NotifyCollectionChangedEventArgs(Windows.UI.Xaml.Interop.NotifyCollectionChangedAction action, Windows.UI.Xaml.Interop.IBindableVector newItems, Windows.UI.Xaml.Interop.IBindableVector oldItems, System.Int32 newIndex, System.Int32 oldIndex)
-->

# Windows.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.NotifyCollectionChangedEventArgs

## -description
Initializes a new instance of the [NotifyCollectionChangedEventArgs](notifycollectionchangedeventargs.md) class.


## -parameters
### -param action
The [Action](notifycollectionchangedeventargs_action.md) value to report.

### -param newItems
The [NewItems](notifycollectionchangedeventargs_newitems.md) value to report.

### -param oldItems
The [OldItems](notifycollectionchangedeventargs_olditems.md) value to report.

### -param newIndex
The [NewStartingIndex](notifycollectionchangedeventargs_newstartingindex.md) value to report.

### -param oldIndex
The [OldStartingIndex](notifycollectionchangedeventargs_oldstartingindex.md) value to report.

## -remarks
When programming with .NET, this class is hidden and developers should use the [System.Collections.Specialized.NotifyCollectionChangedEventArgs](/dotnet/api/system.collections.specialized.notifycollectionchangedeventargs?view=dotnet-uwp-10.0&preserve-view=true) class.

Other than *action*, any of the values for this constructor can potentially be passed as null, depending on the collection change and corresponding [Action](notifycollectionchangedeventargs_action.md) being reported.

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
