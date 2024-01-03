---
-api-id: T:Windows.UI.ViewManagement.InputPane
-api-type: winrt class
---

<!-- Class syntax.
public class InputPane : Windows.UI.ViewManagement.IInputPane, Windows.UI.ViewManagement.IInputPane2, Windows.UI.ViewManagement.IInputPaneControl
-->

# Windows.UI.ViewManagement.InputPane

## -description

Enables an app to receive notifications when the docked touch keyboard, or Soft Input Panel (SIP), is about to be displayed or hidden, and to determine which portion of the application's window is obscured by the input pane.

> [!NOTE]
> The InputPane APIs provide accurate occlusion information for a docked panel only. For Windows 10 Creators Fall Update and newer, we reccomend using the following APIs to handle occlusion by docked, undocked, moveable, and transitory input panes such as Soft Input Panels (SIP), Input Method Editor (IME) candidate windows, floating toolbars, and so on.
>
> - [CoreInputView](../windows.ui.viewmanagement.core/coreinputview.md)
> - [CoreInputViewOcclusion](../windows.ui.viewmanagement.core/coreinputviewocclusion.md)
> - [CoreInputViewOcclusionKind](../windows.ui.viewmanagement.core/coreinputviewocclusionkind.md)

## -remarks

The input pane appears when the user performs an action that requires them to enter information, such as selecting a text entry field. By default, Windows handles the input pane events and repositions content so that users can see where they are typing. If you set [CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual** in your app, you are responsible for showing and hiding the input pane using TryShow and TryHide. Use this class to override the default behavior and customize the input pane.

In some cases, overlay UI such as an InputPane is not fully supported. This includes:

- apps in full-screen mode, like [games](/windows/uwp/gaming/index).
- Windows Holographic apps in [holographic view](https://developer.microsoft.com/mixed-reality#app_views).

Call [GetForCurrentView](inputpane_getforcurrentview_1363600702.md) to get an InputPane object.

After you register to receive input pane notifications, the system calls your event delegate whenever the input pane is shown or hidden for the window that was visible when you called the [GetForCurrentView](inputpane_getforcurrentview_1363600702.md) method.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | GetForUIContext |

## -examples

## -see-also
[Respond to the presence of the touch keyboard](/windows/uwp/design/input/respond-to-the-presence-of-the-touch-keyboard)
