---
-api-id: E:Windows.UI.Xaml.Controls.WebView.ContentLoading
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ContentLoading<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.ContentLoading

## -description
Occurs when the [WebView](webview.md) has started loading new content.

## -xaml-syntax
```xaml
<WebView ContentLoading="eventhandler"/>

```


## -remarks
[WebView](webview.md) navigation events occur in the following order:


+ [NavigationStarting](webview_navigationstarting.md)
+ ContentLoading
+ [DOMContentLoaded](webview_domcontentloaded.md)
+ [NavigationCompleted](webview_navigationcompleted.md)


Similar events occur in the same order for each **iframe** in the [WebView](webview.md) content: 
+ [FrameNavigationStarting](webview_framenavigationstarting.md)
+ [FrameContentLoading](webview_framecontentloading.md)
+ [FrameDOMContentLoaded](webview_framedomcontentloaded.md)
+ [FrameNavigationCompleted](webview_framenavigationcompleted.md)


## -examples

## -see-also
