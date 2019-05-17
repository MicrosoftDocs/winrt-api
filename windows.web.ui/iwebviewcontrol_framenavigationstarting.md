---
-api-id: E:Windows.Web.UI.IWebViewControl.FrameNavigationStarting
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler FrameNavigationStarting<IWebViewControl, WebViewControlNavigationStartingEventArgs>
-->

# Windows.Web.UI.IWebViewControl.FrameNavigationStarting

## -description
Occurs before a frame in the IWebViewControl navigates to new content.

## -remarks
WebView navigation events occur in the following order:

- [NavigationStarting](iwebviewcontrol_navigationstarting.md)
- [ContentLoading](iwebviewcontrol_contentloading.md)
- **DOMContentLoaded**
- [NavigationCompleted](iwebviewcontrol_navigationcompleted.md)

Similar events occur in the same order for each iframe in the WebView content:

- FrameNavigationStarting
- [FrameContentLoading](iwebviewcontrol_framecontentloading.md)
- [FrameDOMContentLoaded](iwebviewcontrol_framedomcontentloaded.md)
- [FrameNavigationCompleted](iwebviewcontrol_navigationcompleted.md)

## -see-also

## -examples

