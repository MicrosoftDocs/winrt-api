---
-api-id: M:Windows.UI.Xaml.Application.OnShareTargetActivated(Windows.ApplicationModel.Activation.ShareTargetActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnShareTargetActivated(Windows.ApplicationModel.Activation.ShareTargetActivatedEventArgs args)
-->

# Windows.UI.Xaml.Application.OnShareTargetActivated

## -description
Invoked when the application is activated through sharing association.

## -parameters
### -param args
Event data for the event.

## -remarks
All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

For example code, see [Share target activation sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ShareTarget).

### Notes for previous versions

> **Windows 8.x**
> If your app is running when it is activated as a Share target, the existing instance of your app is terminated and a new instance of your app is launched to handle the contract.

## -examples

## -see-also
[ShareOperation](../windows.applicationmodel.datatransfer.sharetarget/shareoperation.md), [Share target activation sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ShareTarget)
