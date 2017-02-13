---
-api-id: M:Windows.UI.Xaml.Controls.WebViewBrush.Redraw
-api-type: winrt method
---

<!-- Method syntax
public void Redraw()
-->

# Windows.UI.Xaml.Controls.WebViewBrush.Redraw

## -description
Causes the [WebViewBrush](webviewbrush.md) to get updated source pixels from the associated [WebView](webview.md) and its current content. This happens asynchronously.

## -remarks
A [WebViewBrush](webviewbrush.md) is basically a snapshot of the content being displayed in a [WebView](webview.md). It won't show animations or any dynamic changes to the content. Call [Redraw](webviewbrush_redraw.md) if the source [WebView](webview.md) has changed its content significantly and you want to make a new snapshot to display as the [WebViewBrush](webviewbrush.md) content.

## -examples

## -see-also
[WebView](webview.md)