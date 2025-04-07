---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.GetDeviceSelectorForCallControl
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.VoipCallCoordinator.GetDeviceSelectorForCallControl

<!--
public static string GetDeviceSelectorForCallControl ();
-->


## -description

Returns an Advanced Query Syntax (AQS) string that you can use to enumerate all valid call control capable devices. You can pass the returned string to [DeviceInformation.FindAllAsync](/uwp/api/windows.devices.enumeration.deviceinformation.findallasync) or [DeviceInformation.CreateWatcher](/uwp/api/windows.devices.enumeration.deviceinformation.createwatcher). Valid devices are those of a [VoipCallControlDeviceKind](./voipcallcontroldevicekind.md) that's supported for association, and that's currently connected.

## -returns

An Advanced Query Syntax (AQS) string to enumerate all valid call control capable devices.

## -remarks

## -see-also

## -examples

## -capabilities
voipCall
