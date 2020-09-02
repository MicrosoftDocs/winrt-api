---
-api-id: M:Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAndContinue(Windows.Foundation.Uri,Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public void AuthenticateAndContinue(Windows.Foundation.Uri requestUri, Windows.Foundation.Uri callbackUri)
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAndContinue

## -description
Starts the authentication operation with two inputs.

## -parameters
### -param requestUri
The starting URI of the web service. This URI must be a secure address of https://.

### -param callbackUri
The callback URI that indicates the completion of the web authentication. The broker matches this URI against every URI that it is about to navigate to. The broker never navigates to this URI, instead the broker returns the control back to the application when the user clicks a link or a web server redirection is made.

## -remarks

## -examples

## -see-also
[AuthenticateAndContinue(Uri)](webauthenticationbroker_authenticateandcontinue_1571442307.md), [AuthenticateAndContinue(Uri, Uri, ValueSet, WebAuthenticationOptions)](webauthenticationbroker_authenticateandcontinue_22464923.md), [Web authentication broker](/windows/uwp/security/web-authentication-broker), [How to continue your Windows Phone 8.x app after calling an AndContinue method](/previous-versions/windows/apps/dn631755(v=win.10))
