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
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
The usage and content of a Universal Integrated Circuit Card (UICC), normally called a SIM Card, can be protected by use of a code called the Personal Identification Number (PIN). PIN1 is defined to control normal use of the phone or data modem. PIN2 can be set to allow the use of special functions such as limiting outbound calls to a list of numbers.

A MobileBroadbandPin object is returned by the [GetPin](mobilebroadbandpinmanager_getpin_157691612.md) method on the [MobileBroadbandPinManager](mobilebroadbandpinmanager.md) .

## -examples

## -see-also
[MobileBroadbandPinManager](mobilebroadbandpinmanager.md), [MobileBroadbandPinManager.GetPin](mobilebroadbandpinmanager_getpin_157691612.md)
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
