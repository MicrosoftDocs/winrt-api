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
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
A [MobileBroadbandDeviceServiceDataSession](mobilebroadbanddeviceservicedatasession.md) instance is returned when the [OpenDataSession](mobilebroadbanddeviceservice_opendatasession.md) method is called on the [MobileBroadbandDeviceService](mobilebroadbanddeviceservice.md) object.

## -examples

## -see-also
[MobileBroadbandDeviceService](mobilebroadbanddeviceservice.md), [MobileBroadbandDeviceService.OpenDataSession](mobilebroadbanddeviceservice_opendatasession.md), [MobileBroadbandModem](mobilebroadbandmodem.md), [MobileBroadbandModem.MaxDeviceServiceDataSizeInBytes](mobilebroadbandmodem_maxdeviceservicedatasizeinbytes.md)