---
-api-id: P:Windows.Storage.KnownFolders.MediaServerDevices
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder MediaServerDevices { get; }
-->

# Windows.Storage.KnownFolders.MediaServerDevices

## -description
Gets the folder of media server (Digital Living Network Alliance (DLNA)) devices.

## -property-value
The folder of media server (Digital Living Network Alliance (DLNA)) devices.

## -remarks
### Prerequisites

To access the media server devices folder, in the app manifest, specify at least one of the following capabilities: **Pictures Library**, **Music Library**, or **Videos Library**.

### More info

In the media server devices folder, the app sees only the content that corresponds to the capabilities specified in the app's manifest. For example, an app that specifies only the **Music Library** capability sees only music content in the media server devices folder.

Some Digital Media Servers only support a single media restriction. These servers may incorrectly return 0 files for a query if you've specified two media library capabilities in the app manifest. If you've specified two media library capabilities - for example, **Pictures Library** and **Videos Library** - and a query returns 0 files, try changing the capabilities to specify either a single media library capability or all three media library capabilities. If you specify all 3 media library capabilities, no media restrictions are sent and this problem doesn't occur.

## -examples

## -see-also
