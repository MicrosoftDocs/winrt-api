---
-api-id: T:Windows.UI.ViewManagement.Core.CoreFrameworkInputView
-api-type: winrt class
---

# Windows.UI.ViewManagement.Core.CoreFrameworkInputView

<!--
public sealed class CoreFrameworkInputView
-->

## -description

Provides UI frameworks with the ability to handle [PrimaryViewAnimationStarting](coreframeworkinputview_primaryviewanimationstarting.md) and [OcclusionsChanged](coreframeworkinputview_occlusionschanged.md) events after the corresponding [CoreInputView](coreinputview.md) [PrimaryViewAnimationStarting](coreinputview_primaryviewanimationstarting.md) and [OcclusionsChanged](coreinputview_occlusionschanged.md) events.

This enables a framework to control the display of a docked, undocked, moveable, or transitory input pane (and associated UI), receive notifications when the pane is moved, displayed, or hidden, and to determine which portion of the app's window is obscured by the pane.

> [!NOTE]
> Not supported on HoloLens.

## -remarks

Used by frameworks (such as XAML) or custom text controls only.

The framework can use the info exposed by this object to adjust and reflow UI to account for any occlusion.

The CoreFrameworkInputView APIs support the following types of input panes.  

- Docked Soft Input Panel (SIP) like the **Touch keyboard and handwriting panel** – typically, your app UI reflows.
- Floating toolbar or SIP – typically, your app UI does not reflow.
- Overlay panels such as inline Ink or IME candidate windows – typically, your app UI does not reflow for the edit control, but does reflow for the text/search suggestions.

The input pane appears when the user performs an action that requires them to provide information, such as entering a text field.

By default, Windows handles input pane events and repositions content so that users can see the control with focus.

Call [CoreFrameworkInputView.GetForCurrentView](coreframeworkinputview_getforcurrentview_1363600702.md) to get a CoreFrameworkInputView object.

After you register to receive input pane notifications, the system calls your event delegate whenever the pane is shown or hidden for the foreground window when you called the [CoreFrameworkInputView.GetForCurrentView](coreframeworkinputview_getforcurrentview_1363600702.md) method.

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

## -see-also

[CoreInputView](coreinputview.md)

## -examples
