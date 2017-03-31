---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandPinManager
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandPinManager : Windows.Networking.NetworkOperators.IMobileBroadbandPinManager
-->

# Windows.Networking.NetworkOperators.MobileBroadbandPinManager

## -description
Defines the PIN manager for a given mobile broadband modem and SIM Card.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
The usage and content of a Universal Integrated Circuit Card (UICC), normally called a SIM Card, can be protected by use of a code called the Personal Identification Number (PIN).

A [MobileBroadbandPinManager](mobilebroadbandpinmanager.md) object is returned by the [PinManager](mobilebroadbanddeviceinformation_pinmanager.md) property on the [MobileBroadbandDeviceInformation](mobilebroadbanddeviceinformation.md).

## -examples

## -see-also
[MobileBroadbandDeviceInformation](mobilebroadbanddeviceinformation.md), [MobileBroadbandDeviceInformation.PinManager](mobilebroadbanddeviceinformation_pinmanager.md), [MobileBroadbandPin](mobilebroadbandpin.md)