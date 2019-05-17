---
-api-id: E:Windows.Devices.Enumeration.DeviceWatcher.Updated
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Updated<Windows.Devices.Enumeration.DeviceWatcher,  Windows.Devices.Enumeration.DeviceInformationUpdate>
-->

# Windows.Devices.Enumeration.DeviceWatcher.Updated

## -description
Event that is raised when a device is updated in the collection of enumerated devices.

## -remarks
> [!NOTE]
> An app must subscribe to all of the [added](devicewatcher_added.md), [removed](devicewatcher_removed.md), and updated events to be notified when there are device additions, removals or updates. If an app handles only the [added](devicewatcher_added.md) event, it will not receive an update if a device is added to the system after the initial device enumeration completes.

## -examples

## -see-also
