---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.CreateWatcher(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Enumeration.DeviceWatcher CreateWatcher(System.String aqsFilter)
-->

# Windows.Devices.Enumeration.DeviceInformation.CreateWatcher

## -description
Creates a [DeviceWatcher](devicewatcher.md) for devices matching the specified Advanced Query Syntax (AQS) string.

## -parameters
### -param aqsFilter
An AQS string that filters the [DeviceInformation](deviceinformation.md) objects to enumerate. Typically this string is retrieved from the **GetDeviceSelector** method of a class that interacts with devices. For example, [GetDeviceSelector](../windows.devices.portable/storagedevice_getdeviceselector_838466080.md) retrieves the string for the [StorageDevice](../windows.devices.portable/storagedevice.md) class.

## -returns
The created [DeviceWatcher](devicewatcher.md).

## -remarks
> [!NOTE]
> This overload is not available from JavaScript. To create a [DeviceWatcher](devicewatcher.md) from an AQS string in JavaScript, use the [CreateWatcher(String, IIterable_1)](deviceinformation_createwatcher_490167309.md) overload and pass `null` as the second parameter.

The [DeviceWatcher](devicewatcher.md) first performs an initial enumeration of devices, raising an [Added](devicewatcher_added.md) event for each device that it finds, and raising an [EnumerationCompleted](devicewatcher_enumerationcompleted.md) event when the initial enumeration is complete. After the initial enumeration is complete, it raises events when a device is added, deleted, or updated.

> [!NOTE]
> An app must subscribe to all of the [added](devicewatcher_added.md), [removed](devicewatcher_removed.md), and [updated](devicewatcher_updated.md) events to be notified when there are device additions, removals or updates. If an app handles only the [added](devicewatcher_added.md) event, it will not receive an update if a device is added to the system after the initial device enumeration completes.

See the [DeviceWatcher](devicewatcher.md) class for an example.

## -examples

## -see-also
[CreateWatcher](deviceinformation_createwatcher_1506431823.md), [CreateWatcher(DeviceClass)](deviceinformation_createwatcher_674507571.md), [CreateWatcher(String, IIterable_1)](deviceinformation_createwatcher_490167309.md)
