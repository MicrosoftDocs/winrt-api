---
-api-id: P:Windows.Networking.XboxLive.XboxLiveDeviceAddress.IsValid
-api-type: winrt property
---

<!-- Property syntax
public bool IsValid { get; }
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.IsValid

## -description

Gets a Boolean value indicating whether this **XboxLiveDeviceAddress** is valid.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

`True` when this XboxLiveDeviceAddress is valid; `False` otherwise.

## -remarks

Snapshots are expected to originate from previous calls to **GetSnapshotAsBase64**, **GetSnapshotAsBuffer**, or **GetSnapshotAsBytes**, unmodified. If you pass a snapshot to **CreateFromSnapshotBase64**, **CreateFromSnapshotBuffer**, or **CreateFromSnapshotBytes** that has been modified in any way, then an **XboxLiveDeviceAddress** is created, but its **IsValid** property is false.

## -examples

## -see-also
