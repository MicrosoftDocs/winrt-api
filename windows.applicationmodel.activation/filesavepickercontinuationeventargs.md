---
-api-id: T:Windows.ApplicationModel.Activation.FileSavePickerContinuationEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class FileSavePickerContinuationEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs, Windows.ApplicationModel.Activation.IFileSavePickerContinuationEventArgs
-->

# Windows.ApplicationModel.Activation.FileSavePickerContinuationEventArgs

## -description
Provides information about an activated event that fires after the app was suspended for a file save picker operation.

## -remarks
You access a [FileSavePickerContinuationEventArgs](filesavepickercontinuationeventargs.md) object when you implement an event handler that responds to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **PickSaveFileContinuation**.

For an example that uses the [FileSavePickerContinuationEventArgs](filesavepickercontinuationeventargs.md) class, see [How to continue your Windows Phone Store app after calling an AndContinue method](http://msdn.microsoft.com/library/3398d631-ff80-4336-be45-8ee3ea96fbdb).

## -examples

## -see-also
[IFileSavePickerContinuationEventArgs](ifilesavepickercontinuationeventargs.md), [IContinuationActivatedEventArgs](icontinuationactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)