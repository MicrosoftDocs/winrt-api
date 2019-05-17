---
-api-id: T:Windows.ApplicationModel.Activation.WebAccountProviderActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebAccountProviderActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IWebAccountProviderActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.WebAccountProviderActivatedEventArgs

## -description
Provides information to an app activated as a result of a web account provider operation.

## -remarks
You access a WebAccountProviderActivatedEventArgs object when you implement an event handler that responds to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **WebAccountProvider**.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also
[IWebAccountProviderActivatedEventArgs](iwebaccountprovideractivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)
