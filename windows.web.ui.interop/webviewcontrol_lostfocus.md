---
-api-id: E:Windows.Web.UI.Interop.WebViewControl.LostFocus
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler LostFocus<WebViewControl,  object>
-->

# Windows.Web.UI.Interop.WebViewControl.LostFocus

## -description
Informs your app when the [WebViewControl](/uwp/api/windows.web.ui.interop.webviewcontrol) loses focus. May be initiated by the user clicking inside/outside the WebViewControl or by a programmatic focus change, such as the app calling [SetFocus](/windows/desktop/api/winuser/nf-winuser-setfocus) on a window that is not the WebViewControl or a [MoveFocus](/uwp/api/windows.web.ui.interop.webviewcontrol.movefocus) method call.

## -remarks

## -see-also

## -examples

The following C# sample demonstrates an event using GotFocus and LostFocus with the WebViewControl:

```csharp
WebViewControl webViewControl; 
 
void WebViewControlGotFocus(WebViewControl sender, IInspectable args) 
{ 
    AddFocusHighlightToElement(sender); 
} 
 
void WebViewControlLostFocus(WebViewControl sender, IInspectable args) 
{ 
    RemoveFocusHighlightFromElement(sender); 
} 
 
webViewControl.GotFocus += WebViewControlGotFocus; 
webViewControl.LostFocus += WebViewControlLostFocus
```

The GotFocus and LostFocus event tell the app when WebViewControl receives or loses focus. This could be due to a call to MoveFocus, or due to the user clicking inside/outside the WebViewControl. 
