---
-api-id: T:Windows.Security.Authentication.Web.WebAuthenticationBroker
-api-type: winrt class
---

<!-- Class syntax.
public class WebAuthenticationBroker 
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker

## -description

Starts the authentication operation. You can call the methods of this class multiple times in a single application or across multiple applications at the same time. The [Web authentication broker sample](https://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122) in the Samples gallery is an example of how to use the [WebAuthenticationBroker](webauthenticationbroker.md) class for single sign on (SSO) connections.

## -remarks

All members of this class are static. You can access them without creating an object. To troubleshoot issues when using this class, see the event log. To view the event log, start Eventvwr.exe, and navigate to Application and Services Logs &gt; Microsoft &gt; Windows &gt; WebAuth &gt; Operational.

## -examples

[!code-csharp[webauthenticationbroker](../windows.security.authentication.web/code/webauthenticationbroker/cs/ScenarioInput1.xaml.cs#Snippetwebauthenticationbroker)]

[!code-xml[WebAuthenticationBrokerXAML](../windows.security.authentication.web/code/webauthenticationbroker/cs/Scenario1.xaml#SnippetWebAuthenticationBrokerXAML)]

## -see-also

[Authentication and user identity (JavaScript)](https://msdn.microsoft.com/library/1733481d-fe1f-46b1-8c75-086a89e41b46), [Authentication and user identity](https://msdn.microsoft.com/library/53e36ddc-200a-4850-aaf0-07eca3662bb9), [Quickstart: Connecting to an online identity provider (JavaScript)](https://msdn.microsoft.com/library/5c18bb8d-1c23-4fee-81b2-44ee02affcb6), [Web authentication broker](https://msdn.microsoft.com/library/05f06961-1768-44a7-b185-bcdb74488f85), [Windows authentication broker sample](https://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122), [WebAuthenticationBroker sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620622)

## -capabilities

internetClient
