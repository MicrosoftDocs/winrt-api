---
-api-id: T:Windows.Devices.Sms.SmsDeviceStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Sms.SmsDeviceStatus : int
-->

# SmsDeviceStatus

## -description
Contains values that indicate the readiness of an SMS device to engage in cellular network traffic operations.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -enum-fields
### -field Off:0
The device is powered off.

### -field Ready:1
The device is powered on and ready to be used.

### -field SimNotInserted:2
The SIM card is not inserted into the device.

### -field BadSim:3
The SIM is invalid; PIN unblock key retrials have exceeded the limit.

### -field DeviceFailure:4
General device failure.

### -field SubscriptionNotActivated:5
The service subscription is not activated.

### -field DeviceLocked:6
The device is locked by a PIN or password that prevents the device from initializing and registering on the network.

### -field DeviceBlocked:7
The device is blocked by a PIN or password that prevents the device from initializing and registering on the nework.


## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
