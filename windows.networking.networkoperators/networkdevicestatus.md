---
-api-id: T:Windows.Networking.NetworkOperators.NetworkDeviceStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.NetworkDeviceStatus : int
-->

# NetworkDeviceStatus

## -description
Describes the readiness of a device to connect to a wireless network.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -enum-fields
### -field DeviceNotReady:0
The mobile broadband device is off.

### -field DeviceReady:1
The device is powered on and ready for mobile broadband operations.

### -field SimNotInserted:2
The mobile broadband device does not have a SIM card.

### -field BadSim:3
The SIM card is not valid. This can occur when PIN Unblock Key attempts have exceeded the limit.

### -field DeviceHardwareFailure:4
The mobile broadband device hardware is not responding.

### -field AccountNotActivated:5
A subscription account for the mobile broadband device is not active.

### -field DeviceLocked:6
The mobile broadband device is locked by a PIN or password preventing the device from initializing and registering with a wireless network.

### -field DeviceBlocked:7
The mobile broadband device is blocked by a PIN or password preventing the device from initializing and registering with a wireless network.


## -remarks
Mobile operator Windows Store app can have access to different states of the device. Access to the device states such as device readiness, account activation state, and device lock status are made available through the [NetworkDeviceStatus](networkdevicestatus.md) enumeration. The radio state information is available through the [CurrentRadioState](mobilebroadbanddeviceinformation_currentradiostate.md) enumeration. Note that these are two different states. For example, a radio state **Off** does not translate to a **DeviceNotReady** state and vice versa.

## -examples

## -see-also