---
-api-id: T:Windows.UI.ViewManagement.Core.CoreInputView
-api-type: winrt class
---

<!-- Class syntax.
public class CoreInputView 
-->

# Windows.UI.ViewManagement.Core.CoreInputView

## -description
Enables an app to receive notifications when a docked, undocked, moveable, or transitory input pane (and associated UI) is moved, displayed, or hidden, and to determine which portion of the app's window is obscured by the pane. 


> [!NOTE]
> Not supported on HoloLens.

## -remarks
Used by frameworks (such as XAML) or custom text controls only.

Your app can use the info exposed by this object to adjust and reflow it's UI to account for any occlusion.

The CoreInputView APIs support the following types of input panes.  
- Docked Soft Input Panel (SIP) like the **Touch keyboard and handwriting panel** – typically, your app UI reflows 
- Floating toolbar or SIP – typically, your app UI does not reflow
- Overlay panels such as inline Ink or IME candidate windows – typically, your app UI does not reflow for the edit control, but does reflow for the text/search suggestions

The input pane appears when the user performs an action that requires them to provide information, such as entering a text field. 

By default, Windows handles input pane events and repositions content so that users can see the control with focus. If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual** in your app, you are responsible for showing and hiding the input pane using [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md) and [TryHidePrimaryView](coreinputview_tryhideprimaryview_908065025.md). Use this class to override the default behavior and customize the input pane.

Call [GetForCurrentView](coreinputview_getforcurrentview_1363600702.md) to get a [CoreInputView](coreinputview.md) object.

After you register to receive input pane notifications, the system calls your event delegate whenever the pane is shown or hidden for the window that was visible when you called the [GetForCurrentView](coreinputview_getforcurrentview_1363600702.md) method.

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).

## -see-also
- [CoreInputViewOcclusion](coreinputviewocclusion.md)

## -examples

