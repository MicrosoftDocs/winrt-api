---
-api-id: E:Windows.UI.Xaml.Controls.WebView.DOMContentLoaded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler DOMContentLoaded<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.DOMContentLoaded

## -description
Occurs when the [WebView](webview.md) has finished parsing the current HTML content.

## -xaml-syntax
```xaml
<WebView DOMContentLoaded="eventhandler"/>

```


## -remarks
[WebView](webview.md) navigation events occur in the following order:


+ [NavigationStarting](webview_navigationstarting.md)
+ [ContentLoading](webview_contentloading.md)
+ DOMContentLoaded
+ [NavigationCompleted](webview_navigationcompleted.md)


Similar events occur in the same order for each **iframe** in the [WebView](webview.md) content: 
+ [FrameNavigationStarting](webview_framenavigationstarting.md)
+ [FrameContentLoading](webview_framecontentloading.md)
+ [FrameDOMContentLoaded](webview_framedomcontentloaded.md)
+ [FrameNavigationCompleted](webview_framenavigationcompleted.md)


## -examples

## -see-also
