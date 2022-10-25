---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandSession
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandDeviceServiceCommandSession : Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceCommandSession
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandSession

## -description
Represents a device service command session which allows the caller to submit predefined commands to the modem on a mobile broadband device service.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
A MobileBroadbandDeviceServiceCommandSession instance is returned when the [OpenCommandSession](mobilebroadbanddeviceservice_opencommandsession_1948323689.md) method is called on the [MobileBroadbandDeviceService](mobilebroadbanddeviceservice.md) object.

## -examples

## -see-also
[MobileBroadbandDeviceService](mobilebroadbanddeviceservice.md), [MobileBroadbandModem.MaxDeviceServiceCommandSizeInBytes](mobilebroadbandmodem_maxdeviceservicecommandsizeinbytes.md), [MobileBroadbandDeviceService.OpenCommandSession](mobilebroadbanddeviceservice_opencommandsession_1948323689.md)
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
