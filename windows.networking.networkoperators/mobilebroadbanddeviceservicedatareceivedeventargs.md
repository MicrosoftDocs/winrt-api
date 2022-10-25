---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataReceivedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandDeviceServiceDataReceivedEventArgs : Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceDataReceivedEventArgs
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataReceivedEventArgs

## -description
Provides data for a [DataReceived](mobilebroadbanddeviceservicedatasession_datareceived.md) event on a [MobileBroadbandDeviceServiceDataSession](mobilebroadbanddeviceservicedatasession.md) when data is received .

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
A MobileBroadbandDeviceServiceDataReceivedEventArgs instance is created when the [DataReceived](mobilebroadbanddeviceservicedatasession_datareceived.md) event occurs on a [MobileBroadbandDeviceServiceDataSession](mobilebroadbanddeviceservicedatasession.md) once data is received.

## -examples

## -see-also
[MobileBroadbandDeviceServiceDataSession](mobilebroadbanddeviceservicedatasession.md), [MobileBroadbandDeviceServiceDataSession.DataReceived](mobilebroadbanddeviceservicedatasession_datareceived.md)
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
