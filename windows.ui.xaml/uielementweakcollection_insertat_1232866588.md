---
-api-id: M:Windows.UI.Xaml.UIElementWeakCollection.InsertAt(System.UInt32,Windows.UI.Xaml.UIElement)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void UIElementWeakCollection.InsertAt(UInt32 index, UIElement value)
-->

# Windows.UI.Xaml.UIElementWeakCollection.InsertAt

## -description

Inserts the specified item at the specified index.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.UIElementWeakCollection.InsertAt](/windows/winui/api/microsoft.ui.xaml.uielementweakcollection.insertat) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param index

The zero-based index at which to insert the item.

### -param value

The object to insert into the collection.

## -remarks

InsertAt expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -see-also

## -examples

