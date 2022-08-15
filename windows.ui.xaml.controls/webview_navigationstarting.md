---
-api-id: E:Windows.UI.Xaml.Controls.WebView.NavigationStarting
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NavigationStarting<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.NavigationStarting

## -description
Occurs before the [WebView](webview.md) navigates to new content.

## -xaml-syntax
```xaml
<WebView NavigationStarting="eventhandler" />
```


## -remarks
You can cancel navigation in a handler for this event by setting the [WebViewNavigationStartingEventArgs.Cancel](webviewnavigationstartingeventargs_cancel.md) property to **true**.

[WebView](webview.md) navigation events occur in the following order:


+ NavigationStarting
+ [ContentLoading](webview_contentloading.md)
+ [DOMContentLoaded](webview_domcontentloaded.md)
+ [NavigationCompleted](webview_navigationcompleted.md)


Similar events occur in the same order for each **iframe** in the [WebView](webview.md) content: 
+ [FrameNavigationStarting](webview_framenavigationstarting.md)
+ [FrameContentLoading](webview_framecontentloading.md)
+ [FrameDOMContentLoaded](webview_framedomcontentloaded.md)
+ [FrameNavigationCompleted](webview_framenavigationcompleted.md)


## -examples
The following code example demonstrates how to handle this event to update a text box used as an address bar. For the complete example, see the [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView).

```csharp
void webViewA_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
{
    string url = "";
    try { url = args.Uri.ToString(); }
    finally
    {
        address.Text = url;
        appendLog(String.Format("Starting navigation to: \"{0}\".\n", url));
        pageIsLoading = true;
    }
}

```



## -see-also
[WebViewNavigationStartingEventArgs](webviewnavigationstartingeventargs.md), [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
