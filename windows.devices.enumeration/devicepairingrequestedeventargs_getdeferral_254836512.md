---
-api-id: M:Windows.Devices.Enumeration.DevicePairingRequestedEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Deferral GetDeferral()
-->

# Windows.Devices.Enumeration.DevicePairingRequestedEventArgs.GetDeferral

## -description
Requests a [Deferral](../windows.foundation/deferral.md) to support asynchronous operations.

## -returns
The deferral necessary to support asynchronous actions.

## -remarks
Sometimes it is necessary to create a delay while the user interacts with the application to support a specific [DevicePairingKinds](devicepairingkinds.md) value. For example, with **ProvidePin**, the application needs to wait until the user finishes providing a pin before continuing with the pairing process.

## -examples

## -see-also
