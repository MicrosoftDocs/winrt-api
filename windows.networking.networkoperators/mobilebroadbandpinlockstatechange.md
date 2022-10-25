---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandPinLockStateChange
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandPinLockStateChange : Windows.Networking.NetworkOperators.IMobileBroadbandPinLockStateChange
-->

# Windows.Networking.NetworkOperators.MobileBroadbandPinLockStateChange

## -description
Contains details of a PIN lock state change notification.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
The system creates instances of this class. Your code can retrieve the details for a particular notification by getting of the [MobileBroadbandPinLockStateChangeTriggerDetails.PinLockStateChanges](mobilebroadbandpinlockstatechangetriggerdetails_pinlockstatechanges.md) property.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
