---
-api-id: E:Windows.UI.Xaml.Controls.WebView.WebResourceRequested
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler WebResourceRequested<WebView, WebViewWebResourceRequestedEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.WebResourceRequested

## -description

Occurs when an HTTP request has been made.

## -xaml-syntax

```xaml
<WebView WebResourceRequested="eventhandler"/>
```

## -remarks

This event occurs after the HTTP request has been made. You can use this event to intercept the response before it's processed by the WebView.

## -see-also

## -examples

This example demonstrates how to intercept request for a specific domain generate an alternate response.

```csharp
Uri _myUri = new Uri("http://www.contoso.com");

void InterceptWebRequest(WebView sender, WebResourceRequestedEventArgs args)
{
    if (_myUri.IsBaseOf(args.Request.RequestUri))
    {
        args.Response = GenerateResponse(args.Request);
    }
}

HttpResponseMessage GenerateResponse(HttpRequestMessage request)
{
    // ...
}
```
