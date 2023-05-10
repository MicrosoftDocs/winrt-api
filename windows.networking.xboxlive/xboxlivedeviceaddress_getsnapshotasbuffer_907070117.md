---
-api-id: M:Windows.Networking.XboxLive.XboxLiveDeviceAddress.GetSnapshotAsBuffer
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IBuffer GetSnapshotAsBuffer()
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.GetSnapshotAsBuffer

## -description

Gets a snapshot of the current **XboxLiveDeviceAddress** and returns it as an object that implements **IBuffer**.

You can use this method to save a snapshot for later use with the **XboxLiveDeviceAddress.CreateFromSnapshotBuffer** method.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -returns

The snapshot, in an object that implements **IBuffer**. 

## -remarks

Snapshots are serialized forms of **XboxLiveDeviceAddress** objects that can be transmitted to remote devices through out-of-band channels such as Xbox Live matchmaking. However, they represent a device's network address information at a particular time, and they can change over time. To avoid unnecessary connectivity problems, you should listen for **XboxLiveDeviceAddress.SnapshotChanged** events on the local device address to know when its snapshot contents have been updated, and refresh the serialized snapshot anywhere you've transmitted or cached it, so that remote devices always have the latest information.

## -examples

## -see-also
