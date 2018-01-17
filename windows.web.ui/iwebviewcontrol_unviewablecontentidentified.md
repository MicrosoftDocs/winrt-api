---
-api-id: E:Windows.Web.UI.IWebViewControl.UnviewableContentIdentified
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler UnviewableContentIdentified<IWebViewControl, WebViewControlUnviewableContentIdentifiedEventArgs>
-->

# Windows.Web.UI.IWebViewControl.UnviewableContentIdentified

## -description
Occurs when the IWebViewControl attempts to download an unsupported file.

## -remarks
The IWebViewControl cannot host arbitrary file types, but you can handle this event and use the [Launcher](../windows.system/launcher.md) class to redirect the file to the browser or another app.

## -see-also

## -examples

