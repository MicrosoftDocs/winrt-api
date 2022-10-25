---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandDeviceService
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandDeviceService : Windows.Networking.NetworkOperators.IMobileBroadbandDeviceService
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceService

## -description
Represents a mobile broadband device service.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
The [GetDeviceService](mobilebroadbandmodem_getdeviceservice_1135670295.md) method on the [MobileBroadbandModem](mobilebroadbandmodem.md) gets a specific device service for the mobile broadband modem.

## -examples

## -see-also
[MobileBroadbandDeviceServiceCommandSession](mobilebroadbanddeviceservicecommandsession.md), [MobileBroadbandDeviceServiceDataSession](mobilebroadbanddeviceservicedatasession.md), [MobileBroadbandModem](mobilebroadbandmodem.md), [MobileBroadbandModem.GetDeviceService](mobilebroadbandmodem_getdeviceservice_1135670295.md)
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
