---
-api-id: P:Windows.Security.Authentication.Web.WebAuthenticationResult.ResponseData
-api-type: winrt property
---

<!-- Property syntax
public string ResponseData { get; }
-->

# Windows.Security.Authentication.Web.WebAuthenticationResult.ResponseData

## -description
Contains the protocol data when the operation successfully completes.

## -property-value
The returned data.

## -remarks
When the [WebAuthenticationOptions.UseTitle](webauthenticationoptions.md) option is used, this property contains the value of the webpage title. The [ResponseData](webauthenticationresult_responsedata.md) for HTTP GET and HTTP redirects includes the entire URL. For POST, the data is the entity body.

## -examples

## -see-also
[Authentication and user identity (JavaScript)](https://msdn.microsoft.com/library/1733481d-fe1f-46b1-8c75-086a89e41b46), [Authentication and user identity](https://msdn.microsoft.com/library/53e36ddc-200a-4850-aaf0-07eca3662bb9), [Quickstart: Connecting to an online identity provider (JavaScript)](https://msdn.microsoft.com/library/5c18bb8d-1c23-4fee-81b2-44ee02affcb6), [Web authentication broker](https://msdn.microsoft.com/library/05f06961-1768-44a7-b185-bcdb74488f85), [Windows authentication broker sample](https://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122)
