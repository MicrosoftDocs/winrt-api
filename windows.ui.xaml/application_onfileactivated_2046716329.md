---
-api-id: M:Windows.UI.Xaml.Application.OnFileActivated(Windows.ApplicationModel.Activation.FileActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnFileActivated(Windows.ApplicationModel.Activation.FileActivatedEventArgs args)
-->

# Windows.UI.Xaml.Application.OnFileActivated

## -description
Invoked when the application is activated through file-open.

## -parameters
### -param args
Event data for the event.

## -remarks
[OnFileActivated](application_onfileactivated.md) is a pre-defined activation point handler that is invoked for a core [Activated](../windows.ui.core/corewindow_activated.md) event when the [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **File**.

An app can register to become the default handler for a certain file type. You should only register for a file type if you expect to handle all file launches for that type of file. In addition to overriding [OnFileActivated](application_onfileactivated.md), your app must also specify an extension point in the package manifest. For more info, see [How to handle file activation](http://msdn.microsoft.com/library/6b6cebcc-8d1d-44f4-b243-720656692dc8).

All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate.md) in their implementations.

## -examples

## -see-also
[How to handle file activation](http://msdn.microsoft.com/library/6b6cebcc-8d1d-44f4-b243-720656692dc8), [Handle app activation](http://msdn.microsoft.com/library/da9a6a43-f09d-4512-a2ab-9b6132431007), [Association launching sample](http://go.microsoft.com/fwlink/p/?LinkID=231484)