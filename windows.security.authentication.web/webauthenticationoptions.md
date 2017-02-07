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
Tells the web authentication broker to not render any UI. This option will throw an exception if used with [AuthenticateAndContinue](webauthenticationbroker_authenticateandcontinue_ol.md); [AuthenticateSilentlyAsync](webauthenticationbroker_authenticatesilentlyasync_ol.md), which includes this option implicitly, should be used instead.

### -field UseTitle:2
Tells the web authentication broker to return the window title string of the webpage in the [ResponseData](webauthenticationresult_responsedata.md) property.

### -field UseHttpPost:4
Tells the web authentication broker to return the body of the HTTP POST in the [ResponseData](webauthenticationresult_responsedata.md) property. For use with single sign-on (SSO) only.

### -field UseCorporateNetwork:8
Tells the web authentication broker to render the webpage in an app container that supports privateNetworkClientServer, enterpriseAuthentication, and sharedUserCertificate capabilities. Note the application that uses this flag must have these capabilities as well.


## -remarks

## -examples

## -see-also
[Authentication and user identity (JavaScript)](http://msdn.microsoft.com/library/1733481d-fe1f-46b1-8c75-086a89e41b46), [Authentication and user identity](http://msdn.microsoft.com/library/53e36ddc-200a-4850-aaf0-07eca3662bb9), [Quickstart: Connecting to an online identity provider (JavaScript)](http://msdn.microsoft.com/library/5c18bb8d-1c23-4fee-81b2-44ee02affcb6), [Web authentication broker](http://msdn.microsoft.com/library/05f06961-1768-44a7-b185-bcdb74488f85), [Windows authentication broker sample](http://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122)