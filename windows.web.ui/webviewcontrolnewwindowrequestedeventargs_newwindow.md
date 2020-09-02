---
-api-id: P:Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs.NewWindow
-api-type: winrt property
---

<!-- Property syntax.
public IWebViewControl NewWindow { get;  set; }
-->

# Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs.NewWindow

## -description
Provides a new [`WebViewControl`](/uwp/api/windows.web.ui.interop.webviewcontrol) as the target for a `window.open` script call from inside the requesting `WebViewControl`. The content in target webview is always considered cross-origin to the content in opener webview and vice versa and subject to cross-origin restrictions. The `WebViewControl` provided in the `NewWindow` property must be new, running on the same process as the opener webview and cannot have been navigated. Setting the `NewWindow` property takes priority over the `Handled` property. If `NewWindow` is set, then the provided `WebViewControl` is used. If `NewWindow` is not set, then `Handled` is checked to determine behavior for the new window request.

## -property-value

## -remarks

## -see-also

## -examples

The following C# sample demonstrates window.open being allowed to create a new WebViewControl that is returned to opener:

```csharp
WebViewControlProcess wvProc;
WebViewControl webView;

void OnWebViewControlNewWindowRequested(WebViewControl sender, WebViewControlNewWindowRequestedEventArgs args)
{
    
    if (args.Uri.Domain == “mydomain.com”)
    {
        using deferral = args.GetDeferral();
        args.NewWindow = await wvProc.CreateWebViewControlAsync(
            parentWindow, targetWebViewBounds);
        deferral.Complete();
    }
    else
    {
        // Prevent WebView from launching in the default browser.
        args.Handled = true;
    }
}

String htmlContent = “<html><script>window.open(‘http://mydomain.com’)</script><body></body></html>”;

webView.NavigateToString(htmlContent);
```