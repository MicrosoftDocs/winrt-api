---
-api-id: M:Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAsync(Windows.Security.Authentication.Web.WebAuthenticationOptions,Windows.Foundation.Uri,Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.WebAuthenticationResult> AuthenticateAsync(Windows.Security.Authentication.Web.WebAuthenticationOptions options, Windows.Foundation.Uri requestUri, Windows.Foundation.Uri callbackUri)
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAsync

## -description
Starts the asynchronous authentication operation with three inputs. You can call this method multiple times in a single application or across multiple applications at the same time.

## -parameters
### -param options
The options for the authentication operation.

### -param requestUri
The starting URI of the web service. This URI must be a secure address of https://.

### -param callbackUri
The callback URI that indicates the completion of the web authentication. The broker matches this URI against every URI that it is about to navigate to. The broker never navigates to this URI, instead the broker returns the control back to the application when the user clicks a link or a web server redirection is made.

## -returns
The way to query the status and get the results of the authentication operation. If you are getting an invalid parameter error, the most common cause is that you are not using HTTPS for the *requestUri* parameter.

## -remarks
When this method is used, no session state or persisted cookies are retained across multiple calls from the same or different UWP app. This method must be called on the UI thread.

## -examples

## -see-also
[AuthenticateAsync(WebAuthenticationOptions, Uri)](webauthenticationbroker_authenticateasync_1561991399.md), [Authentication and user identity (JavaScript)](https://msdn.microsoft.com/library/1733481d-fe1f-46b1-8c75-086a89e41b46), [Authentication and user identity](https://msdn.microsoft.com/library/53e36ddc-200a-4850-aaf0-07eca3662bb9), [Quickstart: Connecting to an online identity provider (JavaScript)](https://msdn.microsoft.com/library/5c18bb8d-1c23-4fee-81b2-44ee02affcb6), [Web authentication broker](https://msdn.microsoft.com/library/05f06961-1768-44a7-b185-bcdb74488f85), [Windows authentication broker sample](https://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122)
