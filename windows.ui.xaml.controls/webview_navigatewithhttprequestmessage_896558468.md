---
-api-id: M:Windows.UI.Xaml.Controls.WebView.NavigateWithHttpRequestMessage(Windows.Web.Http.HttpRequestMessage)
-api-type: winrt method
---

<!-- Method syntax
public void NavigateWithHttpRequestMessage(Windows.Web.Http.HttpRequestMessage requestMessage)
-->

# Windows.UI.Xaml.Controls.WebView.NavigateWithHttpRequestMessage

## -description
Navigates the [WebView](webview.md) to a URI with a POST request and HTTP headers.

## -parameters
### -param requestMessage
The details of the HTTP request.

## -remarks
This method supports only [HttpMethod.Post](../windows.web.http/httpmethod_post.md) and [HttpMethod.Get](../windows.web.http/httpmethod_get.md) for the [HttpRequestMessage.Method](../windows.web.http/httprequestmessage_method.md) property value.

> [!WARNING]
> If you add additional headers to this request, such as authentication credentials, remember that those headers will also be included with any subsequent child requests. Use caution to prevent accidental disclosure of confidential or personal information.

If the app possesses the `enterpriseCloudSSO` capability,
then web pages hosted inside the WebView control
can use single sign on with Azure Active Directory (AAD) resources.

## -examples
This example shows how to create an HTTP request and use it with this method.

```csharp
HttpRequestMessage httpRequestMessage = new HttpRequestMessage(
    HttpMethod.Post, new Uri("http://www.contoso.com"));
httpRequestMessage.Content = new HttpStringContent("hello, world");
httpRequestMessage.Headers.Append("X-My-Client","true");

myWebView.NavigateWithHttpRequestMessage(httpRequestMessage);
```

## -see-also

## -capabilities
enterpriseCloudSSO
