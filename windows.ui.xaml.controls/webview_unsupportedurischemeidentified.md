---
-api-id: E:Windows.UI.Xaml.Controls.WebView.UnsupportedUriSchemeIdentified
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler UnsupportedUriSchemeIdentified<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.UnsupportedUriSchemeIdentified

## -description
Occurs when an attempt is made to navigate to a Uniform Resource Identifier (URI) using a scheme that [WebView](webview.md) doesn't support.

## -xaml-syntax
```xaml
<WebView UnsupportedUriSchemeIdentified="eventhandler"/>
```


## -remarks
See [WebViewUnsupportedUriSchemeIdentifiedEventArgs](webviewunsupportedurischemeidentifiedeventargs.md).

[WebView](webview.md) supports navigation to Uniform Resource Identifier (URI) using these schemes: http, https, ms-appx-web, and ms-local-stream.

If an attempt is made to navigate to a Uniform Resource Identifier (URI) that the [WebView](webview.md) doesn't support, the navigation is blocked. By default, when an unsupported Uniform Resource Identifier (URI) scheme is encountered, the launcher is invoked to find the default provider for the Uniform Resource Identifier (URI) scheme. You can handle the [UnsupportedUriSchemeIdentified](webview_unsupportedurischemeidentified.md) event to decide how to handle an unsupported Uniform Resource Identifier (URI) scheme. If you do nothing, the launcher is invoked. If you provide custom handling for the Uniform Resource Identifier (URI) scheme, set the [Handled](webviewunsupportedurischemeidentifiedeventargs_handled.md) property to true to prevent the default provider for the Uniform Resource Identifier (URI) scheme from being invoked.

## -examples
```xaml
<WebView x:Name="myWebView" UnsupportedUriSchemeIdentified="OnUnsupportedUriSchemeIdentified" /> 

```

```csharp
private void OnUnsupportedUriSchemeIdentified (WebView sender, WebViewUnsupportedUriSchemeIdentifiedEventArgs e) 
{ 
    // Block all URIs from invoking other apps except the mailto: protocol. 
    if (e.Uri.Scheme != "mailto") 
    { 
        e.Handled= true; 
    } 
} 

```



## -see-also
[WebViewUnsupportedUriSchemeIdentifiedEventArgs](webviewunsupportedurischemeidentifiedeventargs.md)