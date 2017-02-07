---
-api-id: T:Windows.ApplicationModel.ILeavingBackgroundEventArgs
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ILeavingBackgroundEventArgs : 
-->

# Windows.ApplicationModel.ILeavingBackgroundEventArgs

## -description
Gets the deferral object when the app is leaving the background state.

## -remarks
> [!TIP]
> This event is raised before any UI is shown and is a good place to ensure that any assets that you load programmatically are ready so that the UI will be presented correctly.

## -examples

## -see-also
[LeavingBackgroundEvent](../windows.applicationmodel.core/coreapplication_leavingbackground.md), [LeavingBackgroundEventArgs](leavingbackgroundeventargs.md), [Application.LeavingBackground event](../windows.ui.xaml/application_leavingbackground.md), [CoreApplication.LeavingBackground event](../windows.applicationmodel.core/coreapplication_leavingbackground.md)