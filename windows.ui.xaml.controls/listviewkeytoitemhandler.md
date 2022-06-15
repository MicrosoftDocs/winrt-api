---
-api-id: T:Windows.UI.Xaml.Controls.ListViewKeyToItemHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate Windows.Foundation.IAsyncOperation<object> ListViewKeyToItemHandler(System.String key)
-->
# Windows.UI.Xaml.Controls.ListViewKeyToItemHandler

## -description
Represents the asynchronous method that will handle callback for the [SetRelativeScrollPositionAsync](listviewpersistencehelper_setrelativescrollpositionasync_2138322716.md) method.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ListViewKeyToItemHandler](/windows/winui/api/microsoft.ui.xaml.controls.listviewkeytoitemhandler) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param key
The key of the [ListView](listview.md) item.

## -returns
An asynchronous operation that, upon successful completion, returns the [ListView](listview.md) item represented by the specified key.

## -remarks

## -examples

## -see-also
[SetRelativeScrollPositionAsync](listviewpersistencehelper_setrelativescrollpositionasync_2138322716.md)
