---
-api-id: T:Windows.ApplicationModel.LeavingBackgroundEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class LeavingBackgroundEventArgs : Windows.ApplicationModel.ILeavingBackgroundEventArgs
-->

# Windows.ApplicationModel.LeavingBackgroundEventArgs

## -description
Gets the deferral object when the app is leaving the background state.

## -remarks
This object is passed to the app's leaving background event handler.

> [!TIP]
> This event is raised before any UI is shown and is a good place to ensure that any assets that you load programmatically are ready so that the UI will be presented correctly.

## -examples

## -see-also
[ILeavingBackgroundEventArgs](ileavingbackgroundeventargs.md), [LeavingBackgroundEvent](../windows.applicationmodel.core/coreapplication_leavingbackground.md), [Application.LeavingBackground event](../windows.ui.xaml/application_leavingbackground.md), [CoreApplication.LeavingBackground event](../windows.applicationmodel.core/coreapplication_leavingbackground.md)