---
-api-id: T:Windows.ApplicationModel.Activation.FileOpenPickerContinuationEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class FileOpenPickerContinuationEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs, Windows.ApplicationModel.Activation.IFileOpenPickerContinuationEventArgs
-->

# Windows.ApplicationModel.Activation.FileOpenPickerContinuationEventArgs

## -description
Provides information about an activated event that fires after the app was suspended for a file open picker operation.

## -remarks
You access a [FileOpenPickerContinuationEventArgs](fileopenpickercontinuationeventargs.md) object when you implement an event handler that responds to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **PickFileContinuation**.

For an example that uses the [FileOpenPickerContinuationEventArgs](fileopenpickercontinuationeventargs.md) class, see [How to continue your Windows Phone 8.x app after calling an AndContinue method](http://msdn.microsoft.com/library/3398d631-ff80-4336-be45-8ee3ea96fbdb).

## -examples

## -see-also
[IFileOpenPickerContinuationEventArgs](ifileopenpickercontinuationeventargs.md), [IContinuationActivatedEventArgs](icontinuationactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)