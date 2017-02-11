---
-api-id: E:Windows.UI.Xaml.Controls.WebView.FrameNavigationStarting
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler FrameNavigationStarting<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.FrameNavigationStarting

## -description
Occurs before a frame in the [WebView](webview.md) navigates to new content.

## -xaml-syntax
```xaml
<WebView FrameNavigationStarting="eventhandler"/>

```


## -remarks
You can cancel navigation in a handler for this event by setting the [WebViewNavigationStartingEventArgs.Cancel](webviewnavigationstartingeventargs_cancel.md) property to **true**.

[WebView](webview.md) navigation events occur in the following order:


+ [NavigationStarting](webview_navigationstarting.md)
+ [ContentLoading](webview_contentloading.md)
+ [DOMContentLoaded](webview_domcontentloaded.md)
+ [NavigationCompleted](webview_navigationcompleted.md)


Similar events occur in the same order for each **iframe** in the [WebView](webview.md) content: 
+ [FrameNavigationStarting](webview_framenavigationstarting.md)
+ [FrameContentLoading](webview_framecontentloading.md)
+ [FrameDOMContentLoaded](webview_framedomcontentloaded.md)
+ [FrameNavigationCompleted](webview_framenavigationcompleted.md)


## -examples

## -see-also
[WebViewNavigationStartingEventArgs](webviewnavigationstartingeventargs.md)