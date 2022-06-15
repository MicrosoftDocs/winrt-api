---
-api-id: M:Windows.UI.Xaml.ResourceDictionary.Lookup(System.Object)
-api-type: winrt method
---

<!-- Method syntax
public object Lookup(System.Object key)
-->

# Windows.UI.Xaml.ResourceDictionary.Lookup

## -description
Returns the value from the requested key, if an entry with that key exists.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.ResourceDictionary.Lookup](/windows/winui/api/microsoft.ui.xaml.resourcedictionary.lookup) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param key
The requested key.

## -returns
The value, if an item with the specified key exists. Use the **HasKey** method to determine whether the key exists.

## -remarks
> [!NOTE]
> The equivalent Microsoft .NET API is the [Item](/dotnet/api/system.windows.resourcedictionary.item) indexer.

## -examples

## -see-also
@P:System.Collections.Generic.IDictionary`2.Item(`0), [ResourceDictionary and XAML resource references](/windows/uwp/controls-and-patterns/resourcedictionary-and-xaml-resource-references)
