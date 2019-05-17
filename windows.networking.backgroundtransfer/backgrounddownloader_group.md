---
-api-id: P:Windows.Networking.BackgroundTransfer.BackgroundDownloader.Group
-api-type: winrt property
---

<!-- Property syntax
public string Group { get;  set; }
-->

# Windows.Networking.BackgroundTransfer.BackgroundDownloader.Group

## -description
> [!NOTE]
> Group may be altered or unavailable for releases after Windows 8.1. Instead, use [TransferGroup](backgrounddownloader_transfergroup.md).

Gets or sets a string value (e.g. a GUID) indicating the group the transfer will belong to. A download operation with a group ID will only appear in operation enumerations using [GetCurrentDownloadsAsync(String)](backgrounddownloader_getcurrentdownloadsasync_405117897.md) with the specific group string value.

## -property-value
The group name.

## -remarks

## -examples

## -see-also
