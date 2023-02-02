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

> [!NOTE]
> This class was deprecated in Windows 10, version 2004 (build 19041). The file/folder continuation APIs are no longer relevant with the discontinuation of Windows Phone.

You access a `FileSavePickerContinuationEventArgs` object when you implement an event handler that responds to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is `PickSaveFileContinuation`.

For an example that uses the `FileSavePickerContinuationEventArgs` class, see [How to continue your Windows Phone 8.x app after calling an AndContinue method](/previous-versions/windows/apps/dn631755(v=win.10)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also

[IFileSavePickerContinuationEventArgs](ifilesavepickercontinuationeventargs.md), [IContinuationActivatedEventArgs](icontinuationactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)
