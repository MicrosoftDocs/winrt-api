---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandPin
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandPin : Windows.Networking.NetworkOperators.IMobileBroadbandPin
-->

# Windows.Networking.NetworkOperators.MobileBroadbandPin

## -description
Contains the properties and methods associated with a mobile broadband PIN.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
The usage and content of a Universal Integrated Circuit Card (UICC), normally called a SIM Card, can be protected by use of a code called the Personal Identification Number (PIN). PIN1 is defined to control normal use of the phone or data modem. PIN2 can be set to allow the use of special functions such as limiting outbound calls to a list of numbers.

A [MobileBroadbandPin](mobilebroadbandpin.md) object is returned by the [GetPin](mobilebroadbandpinmanager_getpin.md) method on the [MobileBroadbandPinManager](mobilebroadbandpinmanager.md) .

## -examples

## -see-also
[MobileBroadbandPinManager](mobilebroadbandpinmanager.md), [MobileBroadbandPinManager.GetPin](mobilebroadbandpinmanager_getpin.md)