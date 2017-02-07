---
-api-id: T:Windows.ApplicationModel.EnteredBackgroundEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class EnteredBackgroundEventArgs : Windows.ApplicationModel.IEnteredBackgroundEventArgs
-->

# Windows.ApplicationModel.EnteredBackgroundEventArgs

## -description
Gets the deferral object when an app has entered the background state.

## -remarks
This object is passed to the app's entered background event handler.

> [!TIP]
> By the time an app enters the background state, none of its UI is visible.

## -examples

## -see-also
[IEnteredBackgroundEventArgs](ienteredbackgroundeventargs.md), [BackgroundActivated](../windows.applicationmodel.core/coreapplication_backgroundactivated.md), [OnBackgroundActivated](../windows.ui.xaml/application_onbackgroundactivated.md), [Application.EnteredBackground event](../windows.ui.xaml/application_enteredbackground.md), [CoreApplication.EnteredBackground event](../windows.applicationmodel.core/coreapplication_enteredbackground.md)