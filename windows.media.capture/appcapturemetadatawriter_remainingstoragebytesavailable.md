---
-api-id: P:Windows.Media.Capture.AppCaptureMetadataWriter.RemainingStorageBytesAvailable
-api-type: winrt property
---

<!-- Property syntax.
public ulong RemainingStorageBytesAvailable { get; }
-->

# Windows.Media.Capture.AppCaptureMetadataWriter.RemainingStorageBytesAvailable

## -description
Gets the number of bytes remaining in the storage space allocated by the system for app capture metadata items.

## -property-value
The number of bytes remaining for metadata storage.

## -remarks
Because historical app capture is supported, the system accumulates metadata written with **AppCaptureMetadataWriter** even when not actively capturing or broadcasting. When, for example, a capture of the previous 30 seconds is written to a video file on disk, the metadata associated with the recorded time window is included in the file. The system imposes a limit on the storage space that is allocated per app for storing accumulated metadata. You can get the currently available storage space by checking the [RemainingStorageBytesAvailable](/uwp/api/windows.media.capture.appcapturemetadatawriter.RemainingStorageBytesAvailable) property.

When the all of the allotted space has been filled, the system will begin purging metadata using the [AppCaptureMetadataPriority](/uwp/api/windows.media.capture.appcapturemetadatapriority) value, specified when the metadata items were written, and the age of each item in order to delete the oldest, least important data first. When this occurs, the [MetadataPurged](/uwp/api/windows.media.capture.appcapturemetadatawriter.MetadataPurged) event is raised. In response to this event, you may choose to reduce the amount of metadata your app is writing, but this is not required.

## -see-also

## -examples

