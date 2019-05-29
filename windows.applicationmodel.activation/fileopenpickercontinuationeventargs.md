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
You access a FileOpenPickerContinuationEventArgs object when you implement an event handler that responds to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **PickFileContinuation**.

For an example that uses the FileOpenPickerContinuationEventArgs class, see [How to continue your Windows Phone 8.x app after calling an AndContinue method](https://docs.microsoft.com/previous-versions/windows/apps/dn631755(v=win.10)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also
[IFileOpenPickerContinuationEventArgs](ifileopenpickercontinuationeventargs.md), [IContinuationActivatedEventArgs](icontinuationactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)
