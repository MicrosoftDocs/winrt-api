---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataSession
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandDeviceServiceDataSession : Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceDataSession
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataSession

## -description
Represents a device service data session which allows the caller to write data to the modem on a mobile broadband device service.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -remarks
A [MobileBroadbandDeviceServiceDataSession](mobilebroadbanddeviceservicedatasession.md) instance is returned when the [OpenDataSession](mobilebroadbanddeviceservice_opendatasession_2126087991.md) method is called on the [MobileBroadbandDeviceService](mobilebroadbanddeviceservice.md) object.

## -examples

## -see-also
[MobileBroadbandDeviceService](mobilebroadbanddeviceservice.md), [MobileBroadbandDeviceService.OpenDataSession](mobilebroadbanddeviceservice_opendatasession_2126087991.md), [MobileBroadbandModem](mobilebroadbandmodem.md), [MobileBroadbandModem.MaxDeviceServiceDataSizeInBytes](mobilebroadbandmodem_maxdeviceservicedatasizeinbytes.md)
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
