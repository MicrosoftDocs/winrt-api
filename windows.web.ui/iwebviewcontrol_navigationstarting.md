---
-api-id: E:Windows.Web.UI.IWebViewControl.NavigationStarting
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler NavigationStarting<IWebViewControl, WebViewControlNavigationStartingEventArgs>
-->

# Windows.Web.UI.IWebViewControl.NavigationStarting

## -description
Occurs before the IWebViewControl navigates to new content.

## -remarks
WebView navigation events occur in the following order:

- NavigationStarting
- [ContentLoading](iwebviewcontrol_contentloading.md)
- **DOMContentLoaded**
- [NavigationCompleted](iwebviewcontrol_navigationcompleted.md)

Similar events occur in the same order for each iframe in the WebView content:

- [FrameNavigationStarting](iwebviewcontrol_framenavigationstarting.md)
- [FrameContentLoading](iwebviewcontrol_framecontentloading.md)
- [FrameDOMContentLoaded](iwebviewcontrol_framedomcontentloaded.md)
- [FrameNavigationCompleted](iwebviewcontrol_navigationcompleted.md)

## -see-also

## -examples

