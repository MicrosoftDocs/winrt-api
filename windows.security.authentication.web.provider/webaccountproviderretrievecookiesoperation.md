---
-api-id: T:Windows.Security.Authentication.Web.Provider.WebAccountProviderRetrieveCookiesOperation
-api-type: winrt class
---

<!-- Class syntax.
public class WebAccountProviderRetrieveCookiesOperation : Windows.Security.Authentication.Web.Provider.IWebAccountProviderBaseReportOperation, Windows.Security.Authentication.Web.Provider.IWebAccountProviderOperation, Windows.Security.Authentication.Web.Provider.IWebAccountProviderRetrieveCookiesOperation
-->

# Windows.Security.Authentication.Web.Provider.WebAccountProviderRetrieveCookiesOperation

## -description
Represents a retrieve cookies operation made by a web account provider.

## -remarks

## -examples
The following demonstrates how to handle a retrieve cookies operation:

```csharp
void HandleRetrieveCookies(WebAccountProviderRetrieveCookiesOperation operation)
{
    try
    {
        // Parse the Uri to retrieve context information
        Uri myUri = ParseMyUri(operation.Context);

        // Do custom logic based on the context
        // INSERT LOGIC HERE

        // Get the HttpCookieCollection for the Uri
        HttpBaseProtocolFilter filt = new HttpBaseProtocolFilter();
        HttpCookieCollection cookies = filt.CookieManager.GetCookies(myUri);
        foreach (HttpCookie cookie in cookies)
        {
            operation.Cookies.Add(cookie);
        }
        operation.ReportCompleted();
    }
    catch (Exception ex)
    {
        WebProviderError error = new WebProviderError(ERROR_CODE_FOO, ex.Message);
        operation.ReportError(error); 
    }
}
```



## -see-also
[IWebAccountProviderOperation](iwebaccountprovideroperation.md), [IWebAccountProviderBaseReportOperation](iwebaccountproviderbasereportoperation.md)