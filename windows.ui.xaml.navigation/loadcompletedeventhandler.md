---
-api-id: T:Windows.UI.Xaml.Navigation.LoadCompletedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void LoadCompletedEventHandler(System.Object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
-->
# Windows.UI.Xaml.Navigation.LoadCompletedEventHandler

## -description

Represents the method that will handle the [LoadCompleted](../windows.ui.xaml.controls/webview_loadcompleted.md) event.

> [!IMPORTANT]
> [LoadCompleted](../windows.ui.xaml.controls/webview_loadcompleted.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [NavigationCompleted](../windows.ui.xaml.controls/webview_navigationcompleted.md).

## -parameters
### -param sender
The source of the event.

### -param e
The event data.


## -remarks

## -examples

The following example code demonstrates the use of this type. For the complete code listing, see the [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView).



[!code-cpp[WebViewNavigation](../windows.ui.xaml.input/code/Controls_WebView/cpp/Scenario1.xaml.cpp#SnippetWebViewNavigation)]

[!code-csharp[WebViewNavigation](../windows.ui.xaml.input/code/Controls_WebView/csharp/Scenario1.xaml.cs#SnippetWebViewNavigation)]

[!code-vb[WebViewNavigation](../windows.ui.xaml.input/code/Controls_WebView/vbnet/Scenario1.xaml.vb#SnippetWebViewNavigation)]

## -see-also
[WebView](../windows.ui.xaml.controls/webview.md), [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
