---
-api-id: E:Windows.Devices.Enumeration.DeviceWatcher.Added
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Added<Windows.Devices.Enumeration.DeviceWatcher,  Windows.Devices.Enumeration.DeviceInformation>
-->

# Windows.Devices.Enumeration.DeviceWatcher.Added

## -description
Event that is raised when a device is added to the collection enumerated by the [DeviceWatcher](devicewatcher.md).

## -remarks
> [!NOTE]
> An app must subscribe to all of the [added](devicewatcher_added.md), [removed](devicewatcher_removed.md), and [updated](devicewatcher_updated.md) events to be notified when there are device additions, removals or updates. If an app handles only the [added](devicewatcher_added.md) event, it will not receive an update if a device is added to the system after the initial device enumeration completes.

## -examples

## -see-also
[Custom USB device sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620530)