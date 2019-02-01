---
-api-id: M:Windows.UI.Xaml.Application.OnFileSavePickerActivated(Windows.ApplicationModel.Activation.FileSavePickerActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnFileSavePickerActivated(Windows.ApplicationModel.Activation.FileSavePickerActivatedEventArgs args)
-->

# Windows.UI.Xaml.Application.OnFileSavePickerActivated

## -description
Invoked when the application is activated through file-save dialog association.

## -parameters
### -param args
Event data for the event.

## -remarks
[OnFileSavePickerActivated](application_onfilesavepickeractivated_425940653.md) is a pre-defined activation point handler that is invoked for a core [Activated](../windows.ui.core/corewindow_activated.md) event when the [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **FileSavePicker**. This occurs when the user saves a file through the file picker and selects the app as the location.

All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

For example code that shows an [OnFileSavePickerActivated](application_onfilesavepickeractivated_425940653.md) override, see [File picker contracts sample](https://go.microsoft.com/fwlink/p/?linkid=231536).

## -examples

## -see-also
[FileSavePickerActivatedEventArgs](../windows.applicationmodel.activation/filesavepickeractivatedeventargs.md), [File picker contracts sample](https://go.microsoft.com/fwlink/p/?linkid=231536)
