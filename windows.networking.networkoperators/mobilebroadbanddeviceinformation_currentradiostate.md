---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation.CurrentRadioState
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.NetworkOperators.MobileBroadbandRadioState CurrentRadioState { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceInformation.CurrentRadioState

## -description
Gets a value indicating the radio state of the device.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -property-value
A value indicating the radio state of the device.

## -remarks
Mobile operator Windows Store app can have access to different states of the device. Access to the device states such as device readiness, account activation state, and device lock status are made available through the [NetworkDeviceStatus](networkdevicestatus.md) enumeration. The radio state information is available through the [CurrentRadioState](mobilebroadbanddeviceinformation_currentradiostate.md) enumeration. Note that these are two different states. For example, a radio state **Off** does not translate to a **DeviceNotReady** state and vice versa.

## -examples

## -see-also
