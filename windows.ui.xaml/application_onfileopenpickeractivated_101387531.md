---
-api-id: M:Windows.UI.Xaml.Application.OnFileOpenPickerActivated(Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnFileOpenPickerActivated(Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs args)
-->

# Windows.UI.Xaml.Application.OnFileOpenPickerActivated

## -description
Invoked when the application is activated through file-open dialog association.

## -parameters
### -param args
Event data for the event.

## -remarks
[OnFileOpenPickerActivated](application_onfileopenpickeractivated_101387531.md) is a pre-defined activation point handler that is invoked for a core [Activated](../windows.ui.core/corewindow_activated.md) event when the [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **FileOpenPicker**.

All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

## -examples

## -see-also
[ActivationKind](../windows.applicationmodel.activation/activationkind.md), [Handle app activation](http://msdn.microsoft.com/library/da9a6a43-f09d-4512-a2ab-9b6132431007), [Association launching sample](http://go.microsoft.com/fwlink/p/?LinkID=231484)