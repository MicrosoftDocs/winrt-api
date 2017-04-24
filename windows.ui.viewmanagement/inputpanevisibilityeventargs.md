---
-api-id: T:Windows.UI.ViewManagement.InputPaneVisibilityEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class InputPaneVisibilityEventArgs : Windows.UI.ViewManagement.IInputPaneVisibilityEventArgs
-->

# Windows.UI.ViewManagement.InputPaneVisibilityEventArgs

## -description
Provides data for the input pane [Hiding](inputpane_hiding.md) and [Showing](inputpane_showing.md) events.

## -remarks
Your app receives this class in its [Hiding](inputpane_hiding.md) and [Showing](inputpane_showing.md) event handlers.

In some cases, overlay UI such as an [InputPane](inputpane.md) is not fully supported. This includes:

+ apps in full-screen mode, like [games](https://msdn.microsoft.com/windows/uwp/gaming/index).
+ Windows Holographic apps in [holographic view](https://developer.microsoft.com/windows/holographic/app_model#app_views).

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).

## -examples

## -see-also