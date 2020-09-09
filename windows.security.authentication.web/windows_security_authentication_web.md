---
-api-id: N:Windows.Security.Authentication.Web
-api-type: winrt namespace
---

# Windows.Security.Authentication.Web

## -description

Enables apps to integrate with online web services without exposing a user's credentials. The web authentication broker provides a set of APIs and infrastructure for apps to use Internet authentication and authorization protocols like OAuth and OpenID.

The single sign-on (SSO) mode of the web authentication broker APIs is provided to enable users to seamlessly authenticate to a single service across multiple apps. The provider of the service must allow the user to explicitly consent to that authentication, typically by providing a "Keep me logged in" option. The provider must also make it clear to the user how their identity is being used, typically by providing a link to a privacy statement from the logon page.

The [Web authentication broker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/WebAuthenticationBroker) in the Samples gallery is an example of how to use single sign on (SSO) for connections.

If your app or its companion website accesses user data in Outlook.com or Microsoft OneDrive, the Live Connect API hides some of the complexities of authentication tokens and make it a bit easier to write code to work with these cloud services. For more information about the Live Connect API, see [Using Live Connect to personalize apps (HTML)](/previous-versions/windows/apps/hh770853(v=win.10)) or [Using Live Connect to personalize apps (XAML)](/previous-versions/windows/apps/hh770854(v=win.10)).

## -remarks

## -examples

## -see-also

[Authentication and user identity (JavaScript)](/previous-versions/windows/apps/dn448918(v=win.10)), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [Quickstart: Connecting to an online identity provider (JavaScript)](/previous-versions/windows/apps/jj856915(v=win.10)), [Web authentication broker](/windows/uwp/security/web-authentication-broker), [Windows authentication broker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/WebAuthenticationBroker), [WebAuthenticationBroker sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebAuthenticationBroker)
