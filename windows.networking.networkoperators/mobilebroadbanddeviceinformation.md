---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandDeviceInformation : Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation, Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation2, Windows.Networking.NetworkOperators.IMobileBroadbandDeviceInformation3
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation

## -description
Represents the current state of the mobile broadband network device for the account.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
If you're trying to get information about a SIM card that uses CMDA, the device information may contain multiple lines. Typically, the first line is for data connection and the second line contains SIM device information.

## -examples

## -see-also
[MobileBroadbandModem](mobilebroadbandmodem.md), [MobileBroadbandModem.DeviceInformation](mobilebroadbandmodem_deviceinformation.md)