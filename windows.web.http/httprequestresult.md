---
-api-id: T:Windows.Web.Http.HttpRequestResult
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class HttpRequestResult : IClosable, IStringable
-->

# Windows.Web.Http.HttpRequestResult

## -description
Combines the original HTTP request along with the following: the resulting HTTP response (if any), an extended error value, and a succeeded indication.

## -remarks
A common way to get an HttpRequestResult is from the return value of the [TryDeleteAsync](httpclient_trydeleteasync_2029828064.md), [TryGetAsync](httpclient_trygetasync_641528473.md), [TryPostAsync](httpclient_trypostasync_1613087419.md) ,[TryPutAsync](httpclient_tryputasync_1991770449.md), or [TrySendRequestAsync](httpclient_trysendrequestasync_1392908712.md) methods on the [HttpClient](httpclient.md) object.

## -see-also

## -examples

