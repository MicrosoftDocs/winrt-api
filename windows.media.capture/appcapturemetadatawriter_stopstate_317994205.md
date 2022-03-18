---
-api-id: M:Windows.Media.Capture.AppCaptureMetadataWriter.StopState(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public void AppCaptureMetadataWriter.StopState(String name)
-->

# Windows.Media.Capture.AppCaptureMetadataWriter.StopState

## -description
Stops the metadata state with the specified identifier.

## -parameters
### -param name
The identifier of the state to be stopped.

## -remarks
Start a metadata state by calling [StartDoubleState](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StartDoubleState_System_String_System_Double_Windows_Media_Capture_AppCaptureMetadataPriority_), [StartInt32State](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StartInt32State_System_String_System_Int32_Windows_Media_Capture_AppCaptureMetadataPriority_), or [StartStringState](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StartStringState_System_String_System_String_Windows_Media_Capture_AppCaptureMetadataPriority_), specifying the state identifier that you can later pass into [StopState](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StopState_System_String_). Stop all states with a single call to [StopAllStates](/uwp/api/windows.media.capture.appcapturemetadatawriter.StopAllStates).

## -see-also
[StopAllStates](/uwp/api/windows.media.capture.appcapturemetadatawriter.StopAllStates),
[StartDoubleState](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StartDoubleState_System_String_System_Double_Windows_Media_Capture_AppCaptureMetadataPriority_),
[StartInt32State](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StartInt32State_System_String_System_Int32_Windows_Media_Capture_AppCaptureMetadataPriority_),
[StartStringState](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StartStringState_System_String_System_String_Windows_Media_Capture_AppCaptureMetadataPriority_)

## -examples

