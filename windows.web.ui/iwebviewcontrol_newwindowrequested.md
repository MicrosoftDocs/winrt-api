---
-api-id: E:Windows.Web.UI.IWebViewControl.NewWindowRequested
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler NewWindowRequested<IWebViewControl, WebViewControlNewWindowRequestedEventArgs>
-->

# Windows.Web.UI.IWebViewControl.NewWindowRequested

## -description
Occurs when a user performs an action in the IWebViewControl that causes content to be opened in a new window.

## -remarks
This event occurs only for user initiated actions. By default, when a user clicks a link in a IWebViewControl that requests to open in a new window, the link launches the default browser. A new window can be caused by the user clicking on an **href**, or a button which calls **window.open**.

Handle this event to provide custom handling of the new window request. You might navigate the IWebViewControl to the desired page, or create a new IWebViewControl in your app to display the requested content. If you provide custom handling of the new window request, set the [Handled](webviewcontrolnewwindowrequestedeventargs_handled.md) property to true to prevent the default browser from being launched.

## -see-also

## -examples

