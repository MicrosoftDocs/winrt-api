---
-api-id: T:Windows.Security.Authentication.Web.Provider.WebAccountProviderGetTokenSilentOperation
-api-type: winrt class
---

<!-- Class syntax.
public class WebAccountProviderGetTokenSilentOperation : Windows.Security.Authentication.Web.Provider.IWebAccountProviderBaseReportOperation, Windows.Security.Authentication.Web.Provider.IWebAccountProviderOperation, Windows.Security.Authentication.Web.Provider.IWebAccountProviderSilentReportOperation, Windows.Security.Authentication.Web.Provider.IWebAccountProviderTokenOperation
-->

# Windows.Security.Authentication.Web.Provider.WebAccountProviderGetTokenSilentOperation

## -description
Represents a get token silently operation.

## -remarks

## -examples
The following demonstrates how to handle a get token silently operation:

```csharp
void HandleGetTokenSilently(WebAccountProviderGetTokenSilentOperation operation)
{
    try
    {
        WebProviderTokenRequest webProviderTokenRequest = operation.ProviderRequest;
        WebTokenRequest tokenRequest = webProviderTokenRequest.ClientRequest;

        // authenticate silently with the tokenrequest and get back an access token
        WebTokenResponse response = new WebTokenResponse(accessToken); 

        // Add any desired properties to send with the response
        response.Properties.Add("responsePropertyKey1", "responesPropertyValue1");
        response.Properties.Add("responsePropertyKey2", "responsePropertyValue2");

        // send the response
        WebProviderTokenResponse providerResponse = new WebProviderTokenResponse(response, 
                                                        DateTimeOffset.Now.AddHours(1));
        IList<WebProviderTokenResponse> responses = operation.Responses;
        responses.Add(providerResponse);
        operation.ReportCompleted();
    }
    catch (Exception ex)
    {
        WebProviderError error = new WebProviderError(ERROR_CODE, ex.Message);
        operation.ReportError(error);
    }
}
```



## -see-also
[IWebAccountProviderTokenOperation](iwebaccountprovidertokenoperation.md), [IWebAccountProviderOperation](iwebaccountprovideroperation.md), [IWebAccountProviderSilentReportOperation](iwebaccountprovidersilentreportoperation.md), [IWebAccountProviderBaseReportOperation](iwebaccountproviderbasereportoperation.md)