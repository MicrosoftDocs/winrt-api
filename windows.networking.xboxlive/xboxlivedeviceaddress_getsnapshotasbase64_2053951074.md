---
-api-id: M:Windows.Networking.XboxLive.XboxLiveDeviceAddress.GetSnapshotAsBase64
-api-type: winrt method
---

<!-- Method syntax
public string GetSnapshotAsBase64()
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.GetSnapshotAsBase64

## -description

Gets a snapshot of the current **XboxLiveDeviceAddress** as a Base64-encoded string.

You can save this snapshot to use later as the base64 parameter in a call to **XboxLiveDeviceAddress.CreateFromSnapshotBase64**.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -returns

The snapshot, as a Base64-encoded string.

## -remarks

Snapshots are serialized forms of **XboxLiveDeviceAddress** objects that can be transmitted to remote devices through out-of-band channels such as Xbox Live matchmaking. However, they represent a device's network address information at a particular time, and they can change over time. To avoid unnecessary connectivity problems, you should listen for **XboxLiveDeviceAddress.SnapshotChanged** events on the local device address to know when its snapshot contents have been updated, and refresh the serialized snapshot anywhere you've transmitted or cached it, so that remote devices always have the latest information.

## -examples

## -see-also
