---
-api-id: M:Windows.Networking.XboxLive.XboxLiveDeviceAddress.CreateFromSnapshotBuffer(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.XboxLive.XboxLiveDeviceAddress CreateFromSnapshotBuffer(Windows.Storage.Streams.IBuffer buffer)
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.CreateFromSnapshotBuffer

## -description

Creates an **XboxLiveDeviceAddress** object from a snapshot stored in a buffer.

Use this method to create an **XboxLiveDeviceAddress** from the snapshot buffer returned from an earlier call to **XboxLiveDeviceAddress.GetSnapshotAsBuffer**.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param buffer

A buffer containing an **XboxLiveDeviceAddress** snapshot.

## -returns

The **XboxLiveDeviceAddress** represented in the snapshot.

## -remarks

The snapshot buffer is expected to originate from a previous call to **GetSnapshotAsBuffer** on the local or remote device, without modification. If the contents of the snapshot have been altered or corrupted, then an **XboxLiveDeviceAddress** object is returned, but the **IsValid** property is false; and attempts to use the **XboxLiveDeviceAddress** to create an endpoint pair will fail.

## -examples

## -see-also
