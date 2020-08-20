---
-api-id: M:Windows.Web.Http.HttpResponseMessage.EnsureSuccessStatusCode
-api-type: winrt method
---

<!-- Method syntax
public Windows.Web.Http.HttpResponseMessage EnsureSuccessStatusCode()
-->

# Windows.Web.Http.HttpResponseMessage.EnsureSuccessStatusCode

## -description

Throws an exception if the [HttpResponseMessage.IsSuccessStatusCode](/uwp/api/windows.web.http.httpresponsemessage.issuccessstatuscode) property for the HTTP response object is `false`; if it's `true`, then no exception is thrown.

## -returns

If no exception is thrown, then the HTTP response object is returned.

## -remarks

If the server doesn't return a successful [HttpStatusCode](httpstatuscode.md) in the **Successful** range (200-299) for the request, then the [HttpResponseMessage.IsSuccessStatusCode](/uwp/api/windows.web.http.httpresponsemessage.issuccessstatuscode) property is set to `false`. Calling **EnsureSuccessStatusCode** causes the value of **IsSuccessStatusCode** to be checked, and an exception thrown if that value is `false`. No exception is thrown if the value is `true`.

Any exception thrown is specific to the Windows Runtime language projection that you're programming in. For C#, for example, a **System.Exception** is thrown, and that exception includes an **HRESULT** that encodes the original HTTP error. For example, if the **HRESULT** is 0x80190194, then remove the 0x8019000 to give 0x00000194, which is decimal 404.

To avoid dealing with exceptions, check the [HttpResponseMessage.IsSuccessStatusCode](/uwp/api/windows.web.http.httpresponsemessage.issuccessstatuscode) property instead of calling **EnsureSuccessStatusCode**.

## -examples

## -see-also

[HttpStatusCode](/uwp/api/windows.web.http.httpstatuscode), [HttpResponseMessage.IsSuccessStatusCode](/uwp/api/windows.web.http.httpresponsemessage.issuccessstatuscode)
