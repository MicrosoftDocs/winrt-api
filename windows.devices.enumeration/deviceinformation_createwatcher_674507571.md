---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.CreateWatcher(Windows.Devices.Enumeration.DeviceClass)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Enumeration.DeviceWatcher CreateWatcher(Windows.Devices.Enumeration.DeviceClass deviceClass)
-->

# Windows.Devices.Enumeration.DeviceInformation.CreateWatcher

## -description
Creates a [DeviceWatcher](devicewatcher.md) for devices matching the specified [DeviceClass](deviceclass.md).

## -parameters
### -param deviceClass
The class of device to enumerate using the [DeviceWatcher](devicewatcher.md).

## -returns
The created [DeviceWatcher](devicewatcher.md).

## -remarks
The [DeviceWatcher](devicewatcher.md) first performs an initial enumeration of devices, raising an [Added](devicewatcher_added.md) event for each device that it finds, and raising an [EnumerationCompleted](devicewatcher_enumerationcompleted.md) event when the initial enumeration is complete. After the initial enumeration is complete, it raises events when a device is added, deleted, or updated.

> [!NOTE]
> An app must subscribe to all of the [added](devicewatcher_added.md), [removed](devicewatcher_removed.md), and [updated](devicewatcher_updated.md) events to be notified when there are device additions, removals or updates. If an app handles only the [added](devicewatcher_added.md) event, it will not receive an update if a device is added to the system after the initial device enumeration completes.

See the [DeviceWatcher](devicewatcher.md) class for an example.

## -examples

## -see-also
[CreateWatcher](deviceinformation_createwatcher_1506431823.md), [CreateWatcher(String)](deviceinformation_createwatcher_4958831.md), [CreateWatcher(String, IIterable_1)](deviceinformation_createwatcher_490167309.md)