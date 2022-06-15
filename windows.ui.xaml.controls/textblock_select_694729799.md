---
-api-id: M:Windows.UI.Xaml.Controls.TextBlock.Select(Windows.UI.Xaml.Documents.TextPointer,Windows.UI.Xaml.Documents.TextPointer)
-api-type: winrt method
---

<!-- Method syntax
public void Select(Windows.UI.Xaml.Documents.TextPointer start, Windows.UI.Xaml.Documents.TextPointer end)
-->

# Windows.UI.Xaml.Controls.TextBlock.Select

## -description
Selects a range of text in the [TextBlock](textblock.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.TextBlock.Select](/windows/winui/api/microsoft.ui.xaml.controls.textblock.select) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param start
An object that represents the start of the range to select.

### -param end
An object that represents the end of the range to select.

## -remarks
In WPF and Silverlight the equivalent API uses integer for start and end positions. This implementation uses [TextPointer](../windows.ui.xaml.documents/textpointer.md) objects to specify the selection.

## -examples

## -see-also
