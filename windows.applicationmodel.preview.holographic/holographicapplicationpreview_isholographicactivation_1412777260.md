---
-api-id: M:Windows.ApplicationModel.Preview.Holographic.HolographicApplicationPreview.IsHolographicActivation(Windows.ApplicationModel.Activation.IActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax.
public bool HolographicApplicationPreview.IsHolographicActivation(IActivatedEventArgs activatedEventArgs)
-->

# Windows.ApplicationModel.Preview.Holographic.HolographicApplicationPreview.IsHolographicActivation

## -description
Gets whether a given app activation is targeted at the holographic shell.

## -parameters

### -param activatedEventArgs
The app activation to inspect.

## -returns
Whether the activation is targeted at the holographic shell.

## -remarks
On a Desktop PC, users can launch an app from either the desktop Start Menu or the holographic Start Menu if they have a Mixed Reality headset.  Users can also activate applications through protocol activations in either the desktop or holographic shell, for example by clicking a link in another app currently located in that shell.  This method lets an app reason about whether a given app activation is targeting the holographic shell or not, which may affect how the app chooses to inititalize its views.

On HoloLens, this will return true for all activations.

## -see-also

## -examples

