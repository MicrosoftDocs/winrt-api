---
-api-id: P:Windows.UI.Xaml.Controls.WebView.Source
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri Source { get;  set; }
-->

# Windows.UI.Xaml.Controls.WebView.Source

## -description
Gets or sets the Uniform Resource Identifier (URI) source of the HTML content to display in the [WebView](webview.md) control.

## -xaml-syntax
```xaml
<WebView Source="uriString"/>
```


## -property-value
The Uniform Resource Identifier (URI) source of the HTML content to display in the [WebView](webview.md) control.

## -remarks
The Source property retains its old value during navigation until the navigation is complete. During navigation, you can get the new Uniform Resource Identifier (URI) through the event arguments for the navigation events.

## -examples

## -see-also
