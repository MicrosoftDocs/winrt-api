---
-api-id: T:Windows.UI.WebUI.WebUIView
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class WebUIView : IWebViewControl
-->

# Windows.UI.WebUI.WebUIView

## -description
Represents a view (window) of the app to the application background script.

## -remarks

Windows 10 web apps support an optional per-application background script that starts before any views are activated and runs for the duration of the process. With this, you can monitor and modify navigations, track state across navigations, monitor navigation errors, and run code before views are activated.

When this background script is specified as the [StartPage](/uwp/schemas/appxpackage/appxmanifestschema2010-v2/element-application) in your [app manifest](/uwp/schemas/appxpackage/appx-package-manifest), each of the app's views (windows) are exposed to the script as instances of the `WebUIView` class, providing the same events, properties, and methods as a general (Win32) [WebView](/uwp/api/windows.ui.xaml.controls.webview).

There are several differences between the HTML [webview](/microsoft-edge/hosting/webview) (x-ms-webview/MSHTMLWebViewElement) and the `WebUIView` class:

&nbsp; | HTML webview | WebUIView class 
:--| :-- | :--
WebUIView async methods| Return [MSWebViewAsyncOperation](/microsoft-edge/hosting/webview/mswebviewasyncoperation) objects | Return JavaScript [promise](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise) objects
`Navigate` method | [Requires](/microsoft-edge/hosting/webview#navigate) a *URI* in the form of a string | [Requires](./webuiview_navigate_1098085581.md) a [Windows.Foundation.Uri](../windows.foundation/uri.md) object
`InvokeScriptAsync` method | [Script arguments](/microsoft-edge/hosting/webview#invokescriptasync) are specified as an arbitrary number of string parameters | [Script arguments](./webuiview_invokescriptasync_1912773610.md) are specified as an array of strings

Any app activation with the background script as the StartPage will rely on the script itself for navigation.

## -see-also

## -examples

Your app can listen for the [NewWebUIViewCreated](../windows.ui.webui/webuiapplication_newwebuiviewcreated.md) event to intercept control of the navigation for a new view (exposed from [NewWebUIEventCreatedEventArgs.WebUIView](./newwebuiviewcreatedeventargs_webuiview.md)):

```javascript
Windows.UI.WebUI.WebUIApplication.addEventListener("newwebuiviewcreated", newWebUIViewCreatedEventHandler);
```
