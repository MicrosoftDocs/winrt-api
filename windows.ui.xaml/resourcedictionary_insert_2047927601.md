---
-api-id: M:Windows.UI.Xaml.ResourceDictionary.Insert(System.Object,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public bool Insert(System.Object key, System.Object value)
-->

# Windows.UI.Xaml.ResourceDictionary.Insert

## -description
Adds a new entry to the [ResourceDictionary](resourcedictionary.md).

Equivalent WinUI method: [Microsoft.UI.Xaml.ResourceDictionary.Insert](/windows/winui/api/microsoft.ui.xaml.resourcedictionary.insert).

## -parameters
### -param key
The object key for the resource to insert.

### -param value
The object value for the resource to insert.

## -returns
**false** if calling the method defined a new key. If the key already existed, an exception is thrown.

## -remarks
> [!NOTE]
> The equivalent Microsoft .NET API is [Add](/dotnet/api/system.windows.resourcedictionary.add).

## -examples

## -see-also
[Add](/dotnet/api/system.windows.resourcedictionary.add), [ResourceDictionary and XAML resource references](/windows/uwp/controls-and-patterns/resourcedictionary-and-xaml-resource-references)
