---
-api-id: E:Windows.Web.UI.Interop.WebViewControl.GotFocus
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler GotFocus<WebViewControl,  object>
-->

# Windows.Web.UI.Interop.WebViewControl.GotFocus

## -description
Informs your app when the [WebViewControl](/uwp/api/windows.web.ui.interop.webviewcontrol) receives focus (due to the user clicking inside/outside the WebViewControl). Use in combination with the [LostFocus]() event and programmatic focus changes using the [WebViewControl.MoveFocus](/uwp/api/windows.web.ui.interop.webviewcontrol.movefocus) method.

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
