---
-api-id: M:Windows.UI.ViewManagement.InputPane.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.ViewManagement.InputPane GetForCurrentView()
-->

# Windows.UI.ViewManagement.InputPane.GetForCurrentView

## -description
Gets the [InputPane](inputpane.md) object associated with the application window that is currently visible.

## -returns
The input pane.

## -remarks
This method is the only way to get an input pane object; you can't use the **new** operator to get a new input pane object.

> In some cases, overlay UI such as an [InputPane](inputpane.md) is not fully supported. This includes:+ [ apps](https://msdn.microsoft.com/en-us/windows/uwp/gaming/index) in full-screen mode.
+ Windows Holographic apps in [holographic view](https://developer.microsoft.com/en-us/windows/holographic/app_model#app_views).


## -examples

## -see-also
