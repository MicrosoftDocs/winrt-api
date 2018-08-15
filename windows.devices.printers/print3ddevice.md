---
-api-id: T:Windows.Devices.Printers.Print3DDevice
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class Print3DDevice : Windows.Devices.Printers.IPrint3DDevice
-->

# Windows.Devices.Printers.Print3DDevice

## -description
Represents a 3D printer.

## -remarks
Use the AQS string returned by [GetDeviceSelector](print3ddevice_getdeviceselector_838466080.md) with the [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) APIs to find all 3D printers that are connected to the device. Once you have a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object for a 3D printer, you can use that object's [Id](../windows.devices.enumeration/deviceinformation_id.md) property value as the *deviceId* parameter in [FromIdAsync](print3ddevice_fromidasync_1322863552.md) to create a [Print3DDevice](print3ddevice.md) object.

## -examples

## -see-also
