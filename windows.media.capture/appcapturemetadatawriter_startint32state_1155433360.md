---
-api-id: M:Windows.Media.Capture.AppCaptureMetadataWriter.StartInt32State(System.String,System.Int32,Windows.Media.Capture.AppCaptureMetadataPriority)
-api-type: winrt method
---

<!-- Method syntax.
public void AppCaptureMetadataWriter.StartInt32State(String name, Int32 value, AppCaptureMetadataPriority priority)
-->

# Windows.Media.Capture.AppCaptureMetadataWriter.StartInt32State

## -description
Adds a new double metadata state. 

## -parameters
### -param name
The name of the metadata state.

### -param value
The value of the metadata state.

### -param priority
A member of the [AppCaptureMetadataPriority](https://docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatapriority) enumeration specifying the relative importance of the metadata item. This value and the age of a metadata item are used by the system to determine which metadata items should be purged first when the limit of the allocated storage space for accumulated metadata is reached.

## -remarks
The system associates a metadata state with the window of time between when the state is started and when its value is changed or the state is stopped with a call to [StopAllStates](https://docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatawriter.StopAllStates). To store a integer value that applies to an instantaneous moment in time, use [AddInt32Event](https://docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_AddInt32Event_System_String_System_Int32_Windows_Media_Capture_AppCaptureMetadataPriority_).

## -see-also

## -examples

