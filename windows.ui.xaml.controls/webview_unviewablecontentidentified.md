---
-api-id: E:Windows.UI.Xaml.Controls.WebView.UnviewableContentIdentified
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler UnviewableContentIdentified<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.UnviewableContentIdentified

## -description
Occurs when the [WebView](webview.md) attempts to download an unsupported file.

## -xaml-syntax
```xaml
<WebView UnviewableContentIdentified="eventhandler" />
```


## -remarks
The [WebView](webview.md) control cannot host arbitrary file types, but you can handle this event and use the [Launcher](../windows.system/launcher.md) class to redirect the file to the browser or another app.

## -examples
The following code example demonstrates how to handle this event to launch an external browser when the [WebView](webview.md) control cannot render the target content. For the complete example, see the [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView).

```csharp
void webViewA_UnviewableContentIdentified(WebView sender, 
    WebViewUnviewableContentIdentifiedEventArgs args)
{
    appendLog(String.Format("Content for \"{0}\" cannot be loaded into webview. " +
        "Invoking the default launcher instead.\n", args.Uri.ToString()));

    // We turn around and hand the Uri to the 
    // system launcher to launch the default handler for it.
    Windows.Foundation.IAsyncOperation<bool> b = 
        Windows.System.Launcher.LaunchUriAsync(args.Uri);
    pageIsLoading = false;
}

```



## -see-also
[WebViewUnviewableContentIdentifiedEventArgs](webviewunviewablecontentidentifiedeventargs.md), [Launcher](../windows.system/launcher.md), [XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
