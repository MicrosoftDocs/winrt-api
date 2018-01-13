---
-api-id: M:Windows.Web.UI.IWebViewControl.NavigateWithHttpRequestMessage(Windows.Web.Http.HttpRequestMessage)
-api-type: winrt method
---

<!-- Method syntax.
public void IWebViewControl.NavigateWithHttpRequestMessage(HttpRequestMessage requestMessage)
-->

# Windows.Web.UI.IWebViewControl.NavigateWithHttpRequestMessage

## -description
Navigates the IWebViewControl to a URI with a POST request and HTTP headers.

## -parameters
### -param requestMessage
The details of the HTTP request.

## -remarks
This method supports only [HttpMethod.Post](../windows.web.http/httpmethod_post.md) and [HttpMethod.Get](../windows.web.http/httpmethod_get.md) for the [HttpRequestMessage.Method](../windows.web.http/httprequestmessage_method.md) property value.

> [!WARNING]
> If you add additional headers to this request, such as authentication credentials, remember that those headers will also be included with any subsequent child requests. Use caution to prevent accidental disclosure of confidential or personal information.

## -see-also

## -examples

