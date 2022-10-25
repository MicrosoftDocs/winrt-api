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
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
If you're trying to get information about a SIM card that uses CMDA, the device information may contain multiple lines. Typically, the first line is for data connection and the second line contains SIM device information.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | SimGid1 |
| 1703 | 15063 | SimPnn |
| 1703 | 15063 | SimSpn |

## -examples

## -see-also
[MobileBroadbandModem](mobilebroadbandmodem.md), [MobileBroadbandModem.DeviceInformation](mobilebroadbandmodem_deviceinformation.md)
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
