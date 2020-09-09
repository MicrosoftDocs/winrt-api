---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameReaderAcquisitionMode
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum MediaFrameReaderAcquisitionMode : int 
-->

# Windows.Media.Capture.Frames.MediaFrameReaderAcquisitionMode

## -description
Specifies the way that the system should manage frames acquired from a [MediaFrameReader](/uwp/api/windows.media.capture.frames.mediaframereader) or a [MultiSourceMediaFrameReader](/uwp/api/windows.media.capture.frames.multisourcemediaframereader) when a new frame arrives before the app has finished processing the previous frame.

## -enum-fields
### -field Realtime:0
Frames that arrive while the app's [FrameArrived](/uwp/api/windows.media.capture.frames.mediaframereader.FrameArrived) event handler is executing are dropped. This mode works well for scenarios where processing the most current frame is prioritized, such as real-time computer vision applications.

### -field Buffered:1
Frames that arrive while the app's [FrameArrived](/uwp/api/windows.media.capture.frames.mediaframereader.FrameArrived) event handler is executing are buffered in memory by the system. The **FrameArrived** event is raised for each buffered frame when the event handler for the previous frame has completed. This mode is intended for apps for which the sequence of frames is critical and for which dropped frames will break the scenario. Note that once the system's memory limit for buffered frames has been reached, no more frames will be acquired until the app processes buffered frames, freeing memory for the acquisition of additional frames.

## -remarks
Use a value from this enumeration when setting the [MediaFrameReader.AcquisitionMode](/uwp/api/windows.media.capture.frames.mediaframereader.AcquisitionMode) property or the [MultiSourceMediaFrameReader.AcquisitionMode](/uwp/api/windows.media.capture.frames.multisourcemediaframereader.AcquisitionMode) property.

## -see-also

## -examples

