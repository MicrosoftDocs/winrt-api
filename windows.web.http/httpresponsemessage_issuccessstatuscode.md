---
-api-id: P:Windows.Web.Http.HttpResponseMessage.IsSuccessStatusCode
-api-type: winrt property
---

<!-- Property syntax
public bool IsSuccessStatusCode { get; }
-->

# Windows.Web.Http.HttpResponseMessage.IsSuccessStatusCode

## -description

Gets a value that indicates whether the HTTP response was successful.

## -property-value

A value that indicates whether the HTTP response was successful. `true` if [HttpStatusCode](httpstatuscode.md) is in the **Successful** range (200-299); otherwise, `false`.

## -remarks

If the server doesn't return a successful [HttpStatusCode](httpstatuscode.md) in the **Successful** range (200-299) for the request, then the [HttpResponseMessage.IsSuccessStatusCode](/uwp/api/windows.web.http.httpresponsemessage.issuccessstatuscode) property is set to `false`.

Calling [HttpResponseMessage.EnsureSuccessStatusCode](/uwp/api/windows.web.http.httpresponsemessage.ensuresuccessstatuscode) causes the value of **IsSuccessStatusCode** to be checked, and an exception thrown if that value is `false`.

## -examples

## -see-also
[HttpStatusCode](httpstatuscode.md), [HttpResponseMessage.EnsureSuccessStatusCode](/uwp/api/windows.web.http.httpresponsemessage.ensuresuccessstatuscode)
