---
-api-id: M:Windows.UI.Xaml.TriggerActionCollection.GetMany(System.UInt32,Windows.UI.Xaml.TriggerAction[])
-api-type: winrt method
---

<!-- Method syntax
public uint GetMany(System.UInt32 startIndex, Windows.UI.Xaml.TriggerAction[] items)
-->

# Windows.UI.Xaml.TriggerActionCollection.GetMany

## -description
Retrieves multiple elements in a single pass through the iterator.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.TriggerActionCollection.GetMany](/windows/winui/api/microsoft.ui.xaml.triggeractioncollection.getmany) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param startIndex
The index from which to start retrieval.

### -param items
Provides the destination for the result. Size the initial array size as a *capacity* in order to specify how many results should be retrieved.

## -returns
The number of items retrieved.

## -remarks
> [!NOTE]
> The equivalent Microsoft .NET API is [CopyTo](/dotnet/api/system.windows.triggeractioncollection.copyto).

## -examples

## -see-also
