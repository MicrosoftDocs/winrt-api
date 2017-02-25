---
-api-id: T:Windows.UI.Xaml.Controls.WebViewBrush
-api-type: winrt class
---

<!-- Class syntax.
public class WebViewBrush : Windows.UI.Xaml.Media.TileBrush, Windows.UI.Xaml.Controls.IWebViewBrush
-->

# Windows.UI.Xaml.Controls.WebViewBrush

## -description
Provides a brush that renders the content that is currently hosted in a [WebView](webview.md) control.

## -xaml-syntax
```xaml
<WebViewBrush .../>
```


## -remarks
In Windows 8, the [WebView](webview.md) control has the characteristic that other UI regions such as controls cannot be rendered on top of it. This is because of how window regions are handled internally, particularly how input events are processed and how the screen draws. If you want to render HTML content and also place other UI elements on top of that HTML content, you should use [WebViewBrush](webviewbrush.md) as the render area. The [WebView](webview.md) still provides the HTML source information, and you reference that [WebView](webview.md) through the [SourceName](webviewbrush_sourcename.md) property (or by calling [SetSource](webviewbrush_setsource.md), the method and property yield the same results). [WebViewBrush](webviewbrush.md) does not have this overlay limitation, but it doesn't enable interaction.

> [!NOTE]
> The preceding remarks apply only to apps compiled for Windows 8, even when running on Windows 8.1. Windows 8.1 introduces changes to the [WebView](webview.md) control that fix the issues described here. For Windows 8.1, it's anticipated that scenarios where you'll still use a [WebViewBrush](webviewbrush.md) won't be very common. In most cases you can just use a [WebView](webview.md) control and get the functionality you need.

You can apply a [WebViewBrush](webviewbrush.md) to any property that takes a [Brush](../windows.ui.xaml.media/brush.md). For example, you can set [Shape.Fill](../windows.ui.xaml.shapes/shape_fill.md) or [Control.Background](control_background.md) with a [WebViewBrush](webviewbrush.md).

There are two alternatives for associating a [WebViewBrush](webviewbrush.md) with a [WebView](webview.md) control source:
+ Reference the source [WebView](webview.md) by its identifier name, by setting the [SourceName](webviewbrush_sourcename.md) property.
+ Reference the source [WebView](webview.md) by reference, by calling the [SetSource](webviewbrush_setsource.md) method and passing a [WebView](webview.md) object.




> [!IMPORTANT]
> It's often necessary to call [Redraw](webviewbrush_redraw.md) for a [WebViewBrush](webviewbrush.md) that's declared in XAML in the same UI as is the [WebView](webview.md) source. A [WebView](webview.md) control has an inherently asynchronous behavior that redraws the control when its content is completely loaded. But an associated [WebViewBrush](webviewbrush.md) renders as soon as the XAML is parsed (which might be before the URI content is loaded by the [WebView](webview.md)). Alternatively, you can wait to call [SetSource](webviewbrush_setsource.md) on the [WebViewBrush](webviewbrush.md) until the source content is fully loaded (for example by calling [SetSource](webviewbrush_setsource.md) in the handler for the [WebView.LoadCompleted](webview_loadcompleted.md) event.

> This class is not supported on Windows Phone 8.x. [WebView](webview.md) content will not be captured.

## -examples
The following Windows 8-specific code example demonstrates how to use a [WebViewBrush](webviewbrush.md) to enable XAML-based content to overlap HTML-based content. In this example, the [WebView](webview.md) control is displayed by default so that it remains interactive. When the [ComboBox](combobox.md) drop-down list is open, however, it overlaps the [WebView](webview.md) control. In this case, the [WebView](webview.md) is hidden and the [WebViewBrush](webviewbrush.md) displays the HTML content on a [Rectangle](../windows.ui.xaml.shapes/rectangle.md) occupying the same space.



[!code-xml[WebViewBrushXaml](../windows.ui.xaml.input/code/Controls_WebView/csharp/Scenario6.xaml#SnippetWebViewBrushXaml)]

[!code-cpp[WebViewBrushCode](../windows.ui.xaml.input/code/Controls_WebView/cpp/Scenario6.xaml.cpp#SnippetWebViewBrushCode)]

[!code-csharp[WebViewBrushCode](../windows.ui.xaml.input/code/Controls_WebView/csharp/Scenario6.xaml.cs#SnippetWebViewBrushCode)]

[!code-vb[WebViewBrushCode](../windows.ui.xaml.input/code/Controls_WebView/vbnet/Scenario6.xaml.vb#SnippetWebViewBrushCode)]

## -see-also
[TileBrush](../windows.ui.xaml.media/tilebrush.md), [Brush](../windows.ui.xaml.media/brush.md), [WebView](webview.md), [Use brushes](http://msdn.microsoft.com/library/02141f86-355e-4046-86ea-2a89d615b7db), [XAML WebView control sample](http://go.microsoft.com/fwlink/p/?linkid=238582)
soft.com/fwlink/p/?linkid=238582)
