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
OnFileActivated is a pre-defined activation point handler that is invoked for a core [Activated](../windows.ui.core/corewindow_activated.md) event when the [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **File**.

An app can register to become the default handler for a certain file type. You should only register for a file type if you expect to handle all file launches for that type of file. In addition to overriding OnFileActivated, your app must also specify an extension point in the package manifest. For more info, see [How to handle file activation](/previous-versions/windows/apps/hh779669(v=win.10)).

All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

## -examples

## -see-also
[How to handle file activation](/previous-versions/windows/apps/hh779669(v=win.10)), [Handle app activation](/windows/uwp/launch-resume/activate-an-app), [Association launching sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AssociationLaunching)
