---
-api-id: T:Windows.UI.Xaml.Media.TileBrush
-api-type: winrt class
---

<!-- Class syntax.
public class TileBrush : Windows.UI.Xaml.Media.Brush, Windows.UI.Xaml.Media.ITileBrush
-->

# Windows.UI.Xaml.Media.TileBrush

## -description
Base class that describes a way to paint a region. Parent of [ImageBrush](imagebrush.md).



## -remarks
### **TileBrush** derived classes

TileBrush is the parent class for [ImageBrush](imagebrush.md) and [WebViewBrush](../windows.ui.xaml.controls/webviewbrush.md). The Windows Runtime XAML vocabulary doesn't support **VideoBrush**. If you're porting Microsoft Silverlight XAML, [WebViewBrush](../windows.ui.xaml.controls/webviewbrush.md) approximately replaces **WebBrowserBrush**, but be aware that there are "airspace" improvements regarding [WebView](../windows.ui.xaml.controls/webview.md) render behavior that may obviate the need for a brush that draws HTML content.

## -examples

## -see-also
[Brush](brush.md), [ImageBrush](imagebrush.md), [WebViewBrush](../windows.ui.xaml.controls/webviewbrush.md), [Use brushes](/windows/uwp/graphics/using-brushes)
