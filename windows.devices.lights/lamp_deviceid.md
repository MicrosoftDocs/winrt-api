---
-api-id: P:Windows.Devices.Lights.Lamp.DeviceId
-api-type: winrt property
---

<!-- Property syntax
public string DeviceId { get; }
-->

# Windows.Devices.Lights.Lamp.DeviceId

## -description
Gets the [DeviceInformation Id](../windows.devices.enumeration/deviceinformation_id.md) for a lamp device.

## -property-value
The [DeviceInformation Id](../windows.devices.enumeration/deviceinformation_id.md) for a lamp device.

## -remarks
Pass this ID to the [FromIdAsync](lamp_fromidasync_1322863552.md) method to retrieve the associated [Lamp](lamp.md) object. Implement a handler for the [DeviceWatcher.Removed](../windows.devices.enumeration/devicewatcher_removed.md) event and compare the ID of the [DeviceInformationUpdate](../windows.devices.enumeration/deviceinformationupdate.md) argument to the ID of a [Lamp](lamp.md) object to be notified if the device becomes unavailable.

## -examples

## -see-also
