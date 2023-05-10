---
-api-id: M:Windows.Networking.XboxLive.XboxLiveDeviceAddress.CreateFromSnapshotBase64(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.XboxLive.XboxLiveDeviceAddress CreateFromSnapshotBase64(System.String base64)
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.CreateFromSnapshotBase64

## -description

Creates an **XboxLiveDeviceAddress** object from a snapshot stored in Base64 encoding.

Use this method to create an **XboxLiveDeviceAddress** from the Base64-encoded snapshot returned from an earlier call to **XboxLiveDeviceAddress.GetSnapshotAsBase64**.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param base64

A Base64-encoded snapshot representing an **XboxLiveDeviceAddress**.

## -returns

The **XboxLiveDeviceAddress** represented by the snapshot.

## -remarks

The Base64-encoded snapshot is expected to originate from a previous call to **GetSnapshotAsBase64** on the local or remote device, without modification. If the contents of the snapshot have been altered or corrupted, then an **XboxLiveDeviceAddress** object is returned, but the **IsValid** property is false; and attempts to use the **XboxLiveDeviceAddress** to create an endpoint pair will fail.

## -examples

## -see-also
