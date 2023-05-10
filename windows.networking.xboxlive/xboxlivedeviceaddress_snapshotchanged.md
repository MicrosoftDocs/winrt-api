---
-api-id: E:Windows.Networking.XboxLive.XboxLiveDeviceAddress.SnapshotChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SnapshotChanged<Windows.Networking.XboxLive.XboxLiveDeviceAddress,  object>
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.SnapshotChanged

## -description

Event raised when the snapshot for this **XboxLiveDeviceAddress** has changed.

Snapshots are serialized forms of **XboxLiveDeviceAddress** objects that can be transmitted to remote devices through out-of-band channels such as Xbox Live matchmaking. However, they represent a device's network address information at a particular time, and they can change over time. To avoid unnecessary connectivity problems, you should listen for **XboxLiveDeviceAddress.SnapshotChanged** events on the local device address to know when its snapshot contents have been updated, and refresh the serialized snapshot anywhere you've transmitted or cached it, so that remote devices always have the latest information.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -remarks

## -examples

## -see-also
