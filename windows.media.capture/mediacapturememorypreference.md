---
-api-id: T:Windows.Media.Capture.MediaCaptureMemoryPreference
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.MediaCaptureMemoryPreference : int
-->

# MediaCaptureMemoryPreference

## -description
Specifies the preferred memory location for captured video frames.

## -enum-fields
### -field Auto:0
The system dynamically chooses between CPU and GPU memory.

### -field Cpu:1
CPU memory is used.


## -remarks
Specify a memory preference by setting the [MemoryPreference](mediacaptureinitializationsettings_memorypreference.md) property of the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md) object before calling [MediaCapture.InitializeAsync](/uwp/api/windows.media.capture.mediacapture.initializeasync).

## -examples

## -see-also
## -capabilities
backgroundMediaRecording
