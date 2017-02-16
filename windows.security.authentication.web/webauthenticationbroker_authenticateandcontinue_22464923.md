---
-api-id: M:Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAndContinue(Windows.Foundation.Uri,Windows.Foundation.Uri,Windows.Foundation.Collections.ValueSet,Windows.Security.Authentication.Web.WebAuthenticationOptions)
-api-type: winrt method
---

<!-- Method syntax
public void AuthenticateAndContinue(Windows.Foundation.Uri requestUri, Windows.Foundation.Uri callbackUri, Windows.Foundation.Collections.ValueSet continuationData, Windows.Security.Authentication.Web.WebAuthenticationOptions options)
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAndContinue

## -description
Starts the authentication operation with four inputs.

## -parameters
### -param requestUri
The starting URI of the web service. This URI must be a secure address of https://.

### -param callbackUri
The callback URI that indicates the completion of the web authentication. The broker matches this URI against every URI that it is about to navigate to. The broker never navigates to this URI, instead the broker returns the control back to the application when the user clicks a link or a web server redirection is made.

### -param continuationData
Continuation data to be passed as part of the authentication operation.

### -param options
The options for the authentication operation.

## -remarks

## -examples

## -see-also
[AuthenticateAndContinue(Uri)](webauthenticationbroker_authenticateandcontinue_1571442307.md), [AuthenticateAndContinue(Uri, Uri)](webauthenticationbroker_authenticateandcontinue_1464219191.md), [Web authentication broker](http://msdn.microsoft.com/library/05f06961-1768-44a7-b185-bcdb74488f85), [How to continue your Windows Phone Store app after calling an AndContinue method](http://msdn.microsoft.com/library/3398d631-ff80-4336-be45-8ee3ea96fbdb)