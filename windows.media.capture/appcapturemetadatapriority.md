---
-api-id: T:Windows.Media.Capture.AppCaptureMetadataPriority
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AppCaptureMetadataPriority : int 
-->

# Windows.Media.Capture.AppCaptureMetadataPriority

## -description
Specifies the relative importance of an app capture metadata item stored using [AppCaptureMetadataWriter](/uwp/api/windows.media.capture.appcapturemetadatawriter). When the storage space allotted for accumulated metadata is low, the system will use the priority and age of metadata items to determine the order in which metadata is purged to free storage space.

## -enum-fields
### -field Informational:0
The metadata item is of lower importance than **Important** metadata items.

### -field Important:1
The metadata item is of higher importance than **Informational** metadata items.

## -remarks
**Important** priority means the metadata will be uploaded to the Xbox Live service.  The metadata will be used to help users search clips or annotate broadcasts, among other things.
Both **Important** and **Informational** metadata are embedded in the generated .mp4 file, so you should not include any private user information in the metadata.

## -see-also
[AppCaptureMetadataWriter](/uwp/api/windows.media.capture.appcapturemetadatawriter)

## -examples

