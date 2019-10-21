---
-api-id: E:Windows.Web.UI.IWebViewControl.NavigationCompleted
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler NavigationCompleted<IWebViewControl, WebViewControlNavigationCompletedEventArgs>
-->

# Windows.Web.UI.IWebViewControl.NavigationCompleted

## -description
Occurs when the IWebViewControl has finished loading the current content or if navigation has failed.

## -remarks
WebView navigation events occur in the following order:

- [NavigationStarting](iwebviewcontrol_navigationstarting.md)
- [ContentLoading](iwebviewcontrol_contentloading.md)
- **DOMContentLoaded**
- NavigationCompleted

Similar events occur in the same order for each iframe in the WebView content:

- [FrameNavigationStarting](iwebviewcontrol_framenavigationstarting.md)
- [FrameContentLoading](iwebviewcontrol_framecontentloading.md)
- [FrameDOMContentLoaded](iwebviewcontrol_framedomcontentloaded.md)
- FrameNavigationCompleted

## -see-also

## -examples

