---
-api-id: T:Windows.ApplicationModel.Activation.ProtocolForResultsActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ProtocolForResultsActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs, Windows.ApplicationModel.Activation.IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData, Windows.ApplicationModel.Activation.IProtocolForResultsActivatedEventArgs, Windows.ApplicationModel.Activation.IViewSwitcherProvider
-->

# Windows.ApplicationModel.Activation.ProtocolForResultsActivatedEventArgs

## -description
Received by an application when it is launched by another application with the expectation that it will return results back to the caller.

## -remarks
You access a ProtocolForResultsActivatedEventArgs object when you implement an event handler that responds to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **ProtocolForResults**.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also
[IActivatedEventArgs](iactivatedeventargs.md), [IProtocolActivatedEventArgs](iprotocolactivatedeventargs.md), [IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData](iprotocolactivatedeventargswithcallerpackagefamilynameanddata.md), [IApplicationViewActivatedEventArgs](iapplicationviewactivatedeventargs.md)
