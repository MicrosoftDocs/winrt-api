---
-api-id: E:Windows.Web.UI.IWebViewControl.FrameContentLoading
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler FrameContentLoading<IWebViewControl, WebViewControlContentLoadingEventArgs>
-->

# Windows.Web.UI.IWebViewControl.FrameContentLoading

## -description
Occurs when a frame in the IWebViewControl has finished parsing its current HTML content.

## -remarks
WebView navigation events occur in the following order:

- [NavigationStarting](iwebviewcontrol_navigationstarting.md)
- [ContentLoading](iwebviewcontrol_contentloading.md)
- **DOMContentLoaded**
- [NavigationCompleted](iwebviewcontrol_navigationcompleted.md)

Similar events occur in the same order for each iframe in the WebView content:

- [FrameNavigationStarting](iwebviewcontrol_framenavigationstarting.md)
- FrameContentLoading
- [FrameDOMContentLoaded](iwebviewcontrol_framedomcontentloaded.md)
- [FrameNavigationCompleted](iwebviewcontrol_navigationcompleted.md)
## -see-also

## -examples

