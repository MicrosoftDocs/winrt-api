---
-api-id: T:Windows.Security.Authentication.Web.WebAuthenticationOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.Web.WebAuthenticationOptions : uint
-->

# WebAuthenticationOptions

## -description
Contains the options available to the asynchronous operation.

## -enum-fields
### -field None:0
No options are requested.

### -field SilentMode:1
Tells the web authentication broker to not render any UI. This option will throw an exception if used with [AuthenticateAndContinue](webauthenticationbroker_authenticateandcontinue_1571442307.md); [AuthenticateSilentlyAsync](webauthenticationbroker_authenticatesilentlyasync_444210422.md), which includes this option implicitly, should be used instead.

### -field UseTitle:2
Tells the web authentication broker to return the window title string of the webpage in the [ResponseData](webauthenticationresult_responsedata.md) property.

### -field UseHttpPost:4
Tells the web authentication broker to return the body of the HTTP POST in the [ResponseData](webauthenticationresult_responsedata.md) property. For use with single sign-on (SSO) only.

### -field UseCorporateNetwork:8
Tells the web authentication broker to render the webpage in an app container that supports privateNetworkClientServer, enterpriseAuthentication, and sharedUserCertificate capabilities. Note the application that uses this flag must have these capabilities as well.


## -remarks

## -examples

## -see-also
[Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [Web authentication broker](/windows/uwp/security/web-authentication-broker), [Windows authentication broker sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebAuthenticationBroker)