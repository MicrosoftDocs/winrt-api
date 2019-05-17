---
-api-id: E:Windows.Web.UI.IWebViewControl.FrameDOMContentLoaded
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler FrameDOMContentLoaded<IWebViewControl, WebViewControlDOMContentLoadedEventArgs>
-->

# Windows.Web.UI.IWebViewControl.FrameDOMContentLoaded

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
- [FrameContentLoading](iwebviewcontrol_framecontentloading.md)
- FrameDOMContentLoaded
- [FrameNavigationCompleted](iwebviewcontrol_navigationcompleted.md)

## -see-also

## -examples

