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

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.ResourceDictionary.Insert](/windows/winui/api/microsoft.ui.xaml.resourcedictionary.insert) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param key
The object key for the resource to insert.

### -param value
The object value for the resource to insert.

## -returns
**true** if calling the method replaced a value that already existed for the key; **false** if calling the method defined a new key.

## -remarks
> [!NOTE]
> The equivalent Microsoft .NET API is [Add](/dotnet/api/system.windows.resourcedictionary.add).

## -examples

## -see-also
[Add](/dotnet/api/system.windows.resourcedictionary.add), [ResourceDictionary and XAML resource references](/windows/uwp/controls-and-patterns/resourcedictionary-and-xaml-resource-references)
