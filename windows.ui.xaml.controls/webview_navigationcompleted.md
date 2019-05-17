---
-api-id: E:Windows.UI.Xaml.Controls.WebView.NavigationCompleted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NavigationCompleted<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.NavigationCompleted

## -description
Occurs when the [WebView](webview.md) has finished loading the current content or if navigation has failed.

## -xaml-syntax
```xaml
<WebView NavigationCompleted="eventhandler"/>

```


## -remarks
To determine whether navigation has failed, check the [IsSuccess](webviewnavigationcompletedeventargs_issuccess.md) and [WebErrorStatus](webviewnavigationcompletedeventargs_weberrorstatus.md) properties of the [WebViewNavigationCompletedEventArgs](webviewnavigationcompletedeventargs.md) class.

[WebView](webview.md) navigation events occur in the following order:


+ [NavigationStarting](webview_navigationstarting.md)
+ [ContentLoading](webview_contentloading.md)
+ [DOMContentLoaded](webview_domcontentloaded.md)
+ NavigationCompleted


Similar events occur in the same order for each **iframe** in the [WebView](webview.md) content: 
+ [FrameNavigationStarting](webview_framenavigationstarting.md)
+ [FrameContentLoading](webview_framecontentloading.md)
+ [FrameDOMContentLoaded](webview_framedomcontentloaded.md)
+ [FrameNavigationCompleted](webview_framenavigationcompleted.md)


## -examples

## -see-also
[WebViewNavigationCompletedEventArgs](webviewnavigationcompletedeventargs.md)
