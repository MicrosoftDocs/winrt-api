---
-api-id: M:Windows.Media.Capture.AppCaptureMetadataWriter.StartDoubleState(System.String,System.Double,Windows.Media.Capture.AppCaptureMetadataPriority)
-api-type: winrt method
---

<!-- Method syntax.
public void AppCaptureMetadataWriter.StartDoubleState(String name, Double value, AppCaptureMetadataPriority priority)
-->

# Windows.Media.Capture.AppCaptureMetadataWriter.StartDoubleState

## -description
Adds a new double metadata state. 

## -parameters
### -param name
The name of the metadata state.

### -param value
The value of the metadata state.

### -param priority
A member of the [AppCaptureMetadataPriority](/uwp/api/windows.media.capture.appcapturemetadatapriority) enumeration specifying the relative importance of the metadata item. This value and the age of a metadata item are used by the system to determine which metadata items should be purged first when the limit of the allocated storage space for accumulated metadata is reached.

## -remarks
The system associates a metadata state with the window of time between when the state is started and when its value is changed or the state is stopped with a call to [StopAllStates](/uwp/api/windows.media.capture.appcapturemetadatawriter.StopAllStates). To store a double value that applies to an instantaneous moment in time, use [AddDoubleEvent](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_AddDoubleEvent_System_String_System_Double_Windows_Media_Capture_AppCaptureMetadataPriority_).

## -see-also

## -examples

