---
-api-id: T:Windows.UI.ViewManagement.InputPane
-api-type: winrt class
---

<!-- Class syntax.
public class InputPane : Windows.UI.ViewManagement.IInputPane, Windows.UI.ViewManagement.IInputPane2, Windows.UI.ViewManagement.IInputPaneControl
-->

# Windows.UI.ViewManagement.InputPane

## -description
Enables an app to receive notifications when the input pane is about to be displayed or hidden, and to determine which portion of the application's window is obscured by the input pane.

## -remarks

The input pane appears when the user performs an action that requires them to enter information, such as selecting a text entry field. By default, Windows handles the input pane events and repositions content so that users can see where they are typing. If you set[CoreTextEditContext.InputPaneDisplayPolicy](../windows.ui.text.core/coretexteditcontext_inputpanedisplaypolicy.md) to **Manual** in your app, you are responsible for showing and hiding the input pane using TryShow and TryHide. Use this class to override the default behavior and customize the input pane.

In some cases, overlay UI such as an [InputPane](inputpane.md) is not fully supported. This includes:

+ apps in full-screen mode, like [games](https://msdn.microsoft.com/windows/uwp/gaming/index).
+ Windows Holographic apps in [holographic view](https://developer.microsoft.com/windows/holographic/app_model#app_views).

Call [GetForCurrentView](inputpane_getforcurrentview.md) to get an [InputPane](inputpane.md) object.

After you register to receive input pane notifications, the system calls your event delegate whenever the input pane is shown or hidden for the window that was visible when you called the [GetForCurrentView](inputpane_getforcurrentview.md) method.

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).

## -examples

## -see-also