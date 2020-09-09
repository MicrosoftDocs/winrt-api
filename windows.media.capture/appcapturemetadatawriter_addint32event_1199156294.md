---
-api-id: M:Windows.Media.Capture.AppCaptureMetadataWriter.AddInt32Event(System.String,System.Int32,Windows.Media.Capture.AppCaptureMetadataPriority)
-api-type: winrt method
---

<!-- Method syntax.
public void AppCaptureMetadataWriter.AddInt32Event(String name, Int32 value, AppCaptureMetadataPriority priority)
-->

# Windows.Media.Capture.AppCaptureMetadataWriter.AddInt32Event

## -description
Adds a new integer metadata event. 

## -parameters
### -param name
The name of the metadata event.

### -param value
The value of the metadata event.

### -param priority
A member of the [AppCaptureMetadataPriority](/uwp/api/windows.media.capture.appcapturemetadatapriority) enumeration specifying the relative importance of the metadata item. This value and the age of a metadata item are used by the system to determine which metadata items should be purged first when the limit of the allocated storage space for accumulated metadata is reached.

## -remarks
The system associates a metadata event with a timestamp when this method is called. To store an integer value that applies to a window of time, use [StartInt32State](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StartInt32State_System_String_System_Int32_Windows_Media_Capture_AppCaptureMetadataPriority_).

## -see-also

## -examples

