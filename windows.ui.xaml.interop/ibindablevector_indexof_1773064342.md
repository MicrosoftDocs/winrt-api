---
-api-id: M:Windows.UI.Xaml.Interop.IBindableVector.IndexOf(System.Object,System.UInt32@)
-api-type: winrt method
---

<!-- Method syntax
public bool IndexOf(System.Object value, System.UInt32 index)
-->

# Windows.UI.Xaml.Interop.IBindableVector.IndexOf

## -description
Returns the index of a specified item in the vector.



## -parameters
### -param value
The item to find in the vector.

### -param index
The zero-based index of the item if found. 0 is returned if the item is not found, so be sure to check the return value.

## -returns
**true** if the item is found; **false** if the item is not found.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) interface.

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
