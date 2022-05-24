---
-api-id: T:Windows.ApplicationModel.Activation.WalletActionActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WalletActionActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IWalletActionActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.WalletActionActivatedEventArgs

## -description

> [!CAUTION]
> The Activation.WalletActionActivatedEventArgs class is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Provides information to an app that was launched as the result of a wallet action.

## -remarks
You access a WalletActionActivatedEventArgs object when you implement an event handler that responds to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **WalletAction**.

## -examples

## -see-also
[IWalletActionActivatedEventArgs](iwalletactionactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)
