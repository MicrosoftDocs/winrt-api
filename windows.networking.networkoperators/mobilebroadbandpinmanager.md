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
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
The usage and content of a Universal Integrated Circuit Card (UICC), normally called a SIM Card, can be protected by use of a code called the Personal Identification Number (PIN).

A MobileBroadbandPinManager object is returned by the [PinManager](mobilebroadbanddeviceinformation_pinmanager.md) property on the [MobileBroadbandDeviceInformation](mobilebroadbanddeviceinformation.md).

## -examples

## -see-also
[MobileBroadbandDeviceInformation](mobilebroadbanddeviceinformation.md), [MobileBroadbandDeviceInformation.PinManager](mobilebroadbanddeviceinformation_pinmanager.md), [MobileBroadbandPin](mobilebroadbandpin.md)
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
