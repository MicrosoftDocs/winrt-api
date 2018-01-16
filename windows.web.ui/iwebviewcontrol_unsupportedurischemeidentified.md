---
-api-id: E:Windows.Web.UI.IWebViewControl.UnsupportedUriSchemeIdentified
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler UnsupportedUriSchemeIdentified<IWebViewControl, WebViewControlUnsupportedUriSchemeIdentifiedEventArgs>
-->

# Windows.Web.UI.IWebViewControl.UnsupportedUriSchemeIdentified

## -description
Occurs when an attempt is made to navigate to a Uniform Resource Identifier (URI) using a scheme that IWebViewControl doesn't support.

## -remarks
See [WebViewControlUnsupportedUriSchemeIdentifiedEventArgs](webviewcontrolunsupportedurischemeidentifiedeventargs.md).

IWebViewControl supports navigation to Uniform Resource Identifier (URI) using these schemes: http, https, ms-appx-web, ms-appdata and ms-local-stream.

If an attempt is made to navigate to a Uniform Resource Identifier (URI) that the IebViewControl doesn't support, the navigation is blocked. By default, when an unsupported Uniform Resource Identifier (URI) scheme is encountered, the launcher is invoked to find the default provider for the Uniform Resource Identifier (URI) scheme. You can handle the **UnsupportedUriSchemeIdentified** event to decide how to handle an unsupported Uniform Resource Identifier (URI) scheme. If you do nothing, the launcher is invoked. If you provide custom handling for the Uniform Resource Identifier (URI) scheme, set the [Handled](webviewcontrolunsupportedurischemeidentifiedeventargs_handled.md) property to true to prevent the default provider for the Uniform Resource Identifier (URI) scheme from being invoked.

## -see-also

## -examples

