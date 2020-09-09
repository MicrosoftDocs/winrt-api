---
-api-id: T:Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebAuthenticationBrokerContinuationEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs, Windows.ApplicationModel.Activation.IWebAuthenticationBrokerContinuationEventArgs
-->

# Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs

## -description
Provides information to an app that was launched after being suspended for a web authentication broker operation.

## -remarks
You access a WebAuthenticationBrokerContinuationEventArgs object when you implement an event handler that responds to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **WebAuthenticationBrokerContinuation**.

For an example that uses the WebAuthenticationBrokerContinuationEventArgs class, see [How to continue your Windows Phone 8.x app after calling an AndContinue method](/previous-versions/windows/apps/dn631755(v=win.10)).

## -examples

## -see-also
[IWebAuthenticationBrokerContinuationEventArgs](iwebauthenticationbrokercontinuationeventargs.md), [IContinuationActivatedEventArgs](icontinuationactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md)
