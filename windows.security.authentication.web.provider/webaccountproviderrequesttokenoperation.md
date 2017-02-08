---
-api-id: T:Windows.Security.Authentication.Web.Provider.WebAccountProviderRequestTokenOperation
-api-type: winrt class
---

<!-- Class syntax.
public class WebAccountProviderRequestTokenOperation : Windows.Security.Authentication.Web.Provider.IWebAccountProviderBaseReportOperation, Windows.Security.Authentication.Web.Provider.IWebAccountProviderOperation, Windows.Security.Authentication.Web.Provider.IWebAccountProviderTokenOperation, Windows.Security.Authentication.Web.Provider.IWebAccountProviderUIReportOperation
-->

# Windows.Security.Authentication.Web.Provider.WebAccountProviderRequestTokenOperation

## -description
Represents a request token operation.

## -remarks

## -examples
The following demonstrates an example of how to handle a request token operation:

```csharp
WebAccountProviderRequestTokenOperation webAccountProviderRequestTokenOperation;
string accessToken;

protected override void OnNavigatedTo(NavigationEventArgs e)
{
    this.webAccountProviderRequestTokenOperation = 
        (WebAccountProviderRequestTokenOperation)e.Parameter;
    base.OnNavigatedTo(e);
}

private void Authentication_Click(object sender, RoutedEventArgs e)
{
    Uri uri;
    if (webAccountProviderRequestTokenOperation != null)
    {
        // Build the URI using information about the web account from the request
        uri = new Uri("INSERT URI HERE"); 
    }
    else
    {
        // Build the Uri using user-entered information
        uri = new Uri("INSERT URI HERE"); 
    }
    // Complete authentication using the built Uri
    WebTokenResponse response = new WebTokenResponse(this.accessToken);
    WebProviderTokenResponse providerResponse = 
        new WebProviderTokenResponse(response, DateTimeOffset.Now.AddHours(1));
    webAccountProviderRequestTokenOperation.ProviderResponses.Add(providerResponse);
    // Return the result
    WebAccountManager.SendTokenResultCompleted(webAccountProviderOperation);
}    

```



## -see-also
[IWebAccountProviderTokenOperation](iwebaccountprovidertokenoperation.md), [IWebAccountProviderOperation](iwebaccountprovideroperation.md), [IWebAccountProviderUIReportOperation](iwebaccountprovideruireportoperation.md), [IWebAccountProviderBaseReportOperation](iwebaccountproviderbasereportoperation.md)