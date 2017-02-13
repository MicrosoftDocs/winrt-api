---
-api-id: M:Windows.Media.Devices.CallControl.FromId(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Devices.CallControl FromId(System.String deviceId)
-->

# Windows.Media.Devices.CallControl.FromId

## -description
Returns a [CallControl](callcontrol.md) class that represents the audio communications device specified by the [DeviceInformation ID](../windows.devices.enumeration/deviceinformation_id.md) being passed.

## -parameters
### -param deviceId
The [DeviceInformation ID](../windows.devices.enumeration/deviceinformation_id.md) of the specified audio communications device.

## -returns
A class that represents the specified audio communications device.

## -remarks
This method may return a NULL pointer if the device doesn't support this functionality.

## -examples

## -see-also
