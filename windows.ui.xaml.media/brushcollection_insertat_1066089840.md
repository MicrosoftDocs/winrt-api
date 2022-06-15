---
-api-id: M:Windows.UI.Xaml.Media.BrushCollection.InsertAt(System.UInt32,Windows.UI.Xaml.Media.Brush)
-api-type: winrt method
---

<!-- Method syntax
public void InsertAt(System.UInt32 index, Windows.UI.Xaml.Media.Brush value)
-->

# Windows.UI.Xaml.Media.BrushCollection.InsertAt

## -description
Inserts the specified item at the specified index.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.BrushCollection.InsertAt](/windows/winui/api/microsoft.ui.xaml.media.brushcollection.insertat) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
InsertAt expands the collection and moves all subsequent index items by one.

In contrast, [SetAt](brushcollection_setat_1322540320.md) replaces the item at the index, and the collection count remains the same.

## -examples

## -see-also
