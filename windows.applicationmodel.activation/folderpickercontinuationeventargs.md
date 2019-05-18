---
-api-id: T:Windows.ApplicationModel.Activation.FolderPickerContinuationEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class FolderPickerContinuationEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs, Windows.ApplicationModel.Activation.IFolderPickerContinuationEventArgs
-->

# Windows.ApplicationModel.Activation.FolderPickerContinuationEventArgs

## -description
Provides information about an activated event that fires after the app was suspended for a folder picker operation.

## -remarks
You access a FolderPickerContinuationEventArgs object when you implement an event handler that responds to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **PickFolderContinuation**.

For an example that uses the FolderPickerContinuationEventArgs class, see [How to continue your Windows Phone 8.x app after calling an AndContinue method](https://msdn.microsoft.com/library/3398d631-ff80-4336-be45-8ee3ea96fbdb).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also
[IFolderPickerContinuationEventArgs](ifolderpickercontinuationeventargs.md), [IContinuationActivatedEventArgs](icontinuationactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)
