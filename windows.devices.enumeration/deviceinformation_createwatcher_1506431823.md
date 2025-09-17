---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.CreateWatcher
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Enumeration.DeviceWatcher CreateWatcher()
-->

# Windows.Devices.Enumeration.DeviceInformation.CreateWatcher

## -description
Creates a [DeviceWatcher](devicewatcher.md) for all devices.

## -returns
The created [DeviceWatcher](devicewatcher.md).

## -remarks
The [DeviceWatcher](devicewatcher.md) first performs an initial enumeration of devices, raising an [Added](devicewatcher_added.md) event for each device that it finds, and raising an [EnumerationCompleted](devicewatcher_enumerationcompleted.md) event when the initial enumeration is complete. After the initial enumeration is complete, it raises events when a device is added, deleted, or updated.

See the [DeviceWatcher](devicewatcher.md) class for an example.

## -examples

## -see-also
[CreateWatcher(DeviceClass)](deviceinformation_createwatcher_674507571.md), [CreateWatcher(String)](deviceinformation_createwatcher_4958831.md), [CreateWatcher(String, IIterable_1)](deviceinformation_createwatcher_490167309.md)