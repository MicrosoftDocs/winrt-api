---
-api-id: M:Windows.Networking.XboxLive.XboxLiveDeviceAddress.CreateFromSnapshotBytes(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.XboxLive.XboxLiveDeviceAddress CreateFromSnapshotBytes(System.Byte[] buffer)
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.CreateFromSnapshotBytes

## -description

Creates an **XboxLiveDeviceAddress** from a snapshot stored as an array of bytes.

Use this method to create an **XboxLiveDeviceAddress** object from a saved snapshot retrieved with the **XboxLiveDeviceAddress.GetSnapshotAsBytes** method.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param buffer

The Byte array containing the snapshot.

## -returns

The **XboxLiveDeviceAddress** represented by the snapshot.

## -remarks

The snapshot bytes are expected to originate from a previous call to **GetSnapshotAsBytes** on the local or remote device, without modification. If the contents of the snapshot have been altered or corrupted, then an **XboxLiveDeviceAddress** object is returned; but the **IsValid** property is false, and attempts to use the **XboxLiveDeviceAddress** to create an endpoint pair will fail.

## -examples

## -see-also
