---
-api-id: P:Windows.UI.Xaml.Controls.WebViewBrush.SourceName
-api-type: winrt property
---

<!-- Property syntax
public string SourceName { get;  set; }
-->

# Windows.UI.Xaml.Controls.WebViewBrush.SourceName

## -description
Gets or sets the name of the source [WebView](webview.md) control that provides the HTML content.

## -xaml-syntax
```xaml
<WebViewBrush SourceName="nameOfWebView"/>
```


## -xaml-values
<dl><dt>nameOfWebView</dt><dd>nameOfWebViewThe x:Name or reference name of an existing WebView control in the same UI.</dd>
</dl>
## -property-value
The [Name](../windows.ui.xaml/frameworkelement_name.md) or [x:Name attribute](https://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) of the [WebView](webview.md) that provides the HTML content.

## -remarks
There are two alternatives for associating a [WebViewBrush](webviewbrush.md) with a [WebView](webview.md) control source:
+ Reference the source [WebView](webview.md) by its identifier name, by setting the [SourceName](webviewbrush_sourcename.md) property.
+ Reference the source [WebView](webview.md) by reference, by calling the [SetSource](webviewbrush_setsource_1533101357.md) method and passing a [WebView](webview.md) object.


## -examples

## -see-also
