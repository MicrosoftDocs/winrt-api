---
-api-id: T:Windows.Media.Capture.AppCaptureMetadataPriority
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AppCaptureMetadataPriority : int 
-->

# Windows.Media.Capture.AppCaptureMetadataPriority

## -description
Specifies the relative importance of an app capture metadata item stored using [**AppCaptureMetadataWriter**](https://docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatawriter). When the storage space allotted for accumulated metadata is low, the system will use the priority and age of metadata items to determine the order in which metadata is purged to free storage space.

## -enum-fields
### -field Informational:0
The metadata item is of lower importance than **Important** metadata items.

### -field Important:1
The metadata item is of higher importance than **Informational** metadata items.

## -remarks

## -see-also
[**AppCaptureMetadataWriter**](https://review.docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatawriter)

## -examples

