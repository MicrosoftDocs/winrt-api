---
-api-id: P:Windows.UI.Xaml.Controls.WebView.ExecutionMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.WebViewExecutionMode ExecutionMode { get; }
-->

# Windows.UI.Xaml.Controls.WebView.ExecutionMode

## -description
Gets a value that indicates whether the [WebView](webview.md) hosts content on the UI thread or a non-UI thread.

## -property-value
A value of the enumeration that specifies whether the [WebView](webview.md) hosts content on the UI thread or a non-UI thread.

## -remarks
To create a [WebView](webview.md) with a specific [ExecutionMode](webview_executionmode.md), use the [WebView(WebViewExecutionMode)](webview_webview_499271973.md) constructor.

When the [ExecutionMode](webview_executionmode.md) is **SameThread**, [WebView](webview.md) content is hosted on the UI thread. When the value is **SeparateThread**, content is hosted on a background thread.

When the [WebView](webview.md) is not on the UI thread, the behaviors listed here are not supported:
+ Scroll chaining and pointer chaining. (Input events aren't propagated to parent controls that uses **DirectManipulation** like [ScrollViewer](scrollviewer.md) or [FlipView](flipview.md).)
+ Tab navigation to escape focus on [WebView](webview.md).
+ Printing.


## -examples

## -see-also
[WebViewExecutionMode](webviewexecutionmode.md)