---
-api-id: T:Windows.Security.Authentication.Web.WebAuthenticationBroker
-api-type: winrt class
---

<!-- Class syntax.
public class WebAuthenticationBroker 
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker

## -description

Starts the authentication operation. You can call the methods of this class multiple times in a single application or across multiple applications at the same time. The [Web authentication broker sample](https://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122) in the Samples gallery is an example of how to use the WebAuthenticationBroker class for single sign on (SSO) connections.

## -remarks

All members of this class are static. You can access them without creating an object. To troubleshoot issues when using this class, see the event log. To view the event log, start Eventvwr.exe, and navigate to Application and Services Logs &gt; Microsoft &gt; Windows &gt; WebAuth &gt; Operational.

## -examples

[!code-csharp[webauthenticationbroker](../windows.security.authentication.web/code/webauthenticationbroker/cs/ScenarioInput1.xaml.cs#Snippetwebauthenticationbroker)]

[!code-xaml[WebAuthenticationBrokerXAML](../windows.security.authentication.web/code/webauthenticationbroker/cs/Scenario1.xaml#SnippetWebAuthenticationBrokerXAML)]

## -see-also

[Authentication and user identity (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/dn448918(v=win.10)), [Authentication and user identity](https://docs.microsoft.com/windows/uwp/security/authentication-and-user-identity), [Quickstart: Connecting to an online identity provider (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/jj856915(v=win.10)), [Web authentication broker](https://docs.microsoft.com/windows/uwp/security/web-authentication-broker), [Windows authentication broker sample](https://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122), [WebAuthenticationBroker sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620622)

## -capabilities

internetClient
