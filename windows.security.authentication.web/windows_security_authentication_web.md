---
-api-id: N:Windows.Security.Authentication.Web
-api-type: winrt namespace
---

# Windows.Security.Authentication.Web

## -description

Enables apps to integrate with online web services without exposing a user's credentials. The web authentication broker provides a set of APIs and infrastructure for apps to use Internet authentication and authorization protocols like OAuth and OpenID.

The single sign-on (SSO) mode of the web authentication broker APIs is provided to enable users to seamlessly authenticate to a single service across multiple apps. The provider of the service must allow the user to explicitly consent to that authentication, typically by providing a "Keep me logged in" option. The provider must also make it clear to the user how their identity is being used, typically by providing a link to a privacy statement from the logon page.

The [Web authentication broker sample](http://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122) in the Samples gallery is an example of how to use single sign on (SSO) for connections.

If your app or its companion website accesses user data in Outlook.com or Microsoft OneDrive, the Live Connect API hides some of the complexities of authentication tokens and make it a bit easier to write code to work with these cloud services. For more information about the Live Connect API, see [Using Live Connect to personalize apps (HTML)](http://msdn.microsoft.com/library/d60424a9-4dab-4d3d-8819-3abc40706acb) or [Using Live Connect to personalize apps (XAML)](http://msdn.microsoft.com/library/44239449-a12b-4e93-8fab-519e5c63f283).

## -remarks

## -examples

## -see-also

[Authentication and user identity (JavaScript)](http://msdn.microsoft.com/library/1733481d-fe1f-46b1-8c75-086a89e41b46), [Authentication and user identity](http://msdn.microsoft.com/library/53e36ddc-200a-4850-aaf0-07eca3662bb9), [Quickstart: Connecting to an online identity provider (JavaScript)](http://msdn.microsoft.com/library/5c18bb8d-1c23-4fee-81b2-44ee02affcb6), [Web authentication broker](http://msdn.microsoft.com/library/05f06961-1768-44a7-b185-bcdb74488f85), [Windows authentication broker sample](http://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122), [WebAuthenticationBroker sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620622)
