---
-api-id: M:Windows.Networking.XboxLive.XboxLiveDeviceAddress.GetSnapshotAsBytes(System.Byte[],System.UInt32@)
-api-type: winrt method
---

<!-- Method syntax
public void GetSnapshotAsBytes(System.Byte[] buffer, System.UInt32 bytesWritten)
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.GetSnapshotAsBytes

## -description

Saves an **XboxLiveDeviceAddress** to an array of bytes.

You can use this method to save a snapshot for use with the **XboxLiveDeviceAddress.CreateFromSnapshotBytes** method.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param buffer

The array of bytes to receive the snapshot.

Use the **XboxLiveDeviceAddress.MaxSnapshotBytesSize** property to determine the proper size of the array you pass.

### -param bytesWritten

On successful completion, the number of bytes in the snapshot. On failure, -1.

## -remarks

Snapshots are serialized forms of **XboxLiveDeviceAddress** objects that can be transmitted to remote devices through out-of-band channels such as Xbox Live matchmaking. However, they represent a device's network address information at a particular time, and they can change over time. To avoid unnecessary connectivity problems, you should listen for **XboxLiveDeviceAddress.SnapshotChanged** events on the local device address to know when its snapshot contents have been updated, and refresh the serialized snapshot anywhere you've transmitted or cached it, so that remote devices always have the latest information.

## -examples

## -see-also
