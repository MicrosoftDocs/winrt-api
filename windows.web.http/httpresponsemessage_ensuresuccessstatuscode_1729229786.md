---
-api-id: M:Windows.Web.Http.HttpResponseMessage.EnsureSuccessStatusCode
-api-type: winrt method
---

<!-- Method syntax
public Windows.Web.Http.HttpResponseMessage EnsureSuccessStatusCode()
-->

# Windows.Web.Http.HttpResponseMessage.EnsureSuccessStatusCode

## -description
Throws an exception if the [IsSuccessStatusCode](httpresponsemessage_issuccessstatuscode.md) property for the HTTP response is false.

## -returns
The HTTP response if the request was successful.

## -remarks
This method will throw an exception if the server doesn't return a successful [HttpStatusCode](httpstatuscode.md) in the **Successful** range (200-299) for the request.

## -examples

## -see-also
[HttpStatusCode](httpstatuscode.md)