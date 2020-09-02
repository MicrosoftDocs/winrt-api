---
-api-id: P:Windows.Media.Capture.Frames.MediaFrameReader.AcquisitionMode
-api-type: winrt property
---

<!-- Property syntax.
public MediaFrameReaderAcquisitionMode AcquisitionMode { get;  set; }
-->

# Windows.Media.Capture.Frames.MediaFrameReader.AcquisitionMode

## -description
Gets or sets a value that specifies the way that the system should manage frames acquired from a **MediaFrameReader** when a new frame arrives before the app has finished processing the previous frame.

## -property-value
A value that specifies the frame reader's acquisition mode.

## -remarks
If this property is set to [Realtime](/uwp/api/windows.media.capture.frames.mediaframereaderacquisitionmode), frames that arrive while the app's [FrameArrived](/uwp/api/windows.media.capture.frames.mediaframereader.FrameArrived) event handler is executing are dropped. This mode works well for scenarios where processing the most current frame is prioritized, such as real-time computer vision applications.

If this property is set to [Buffered](/uwp/api/windows.media.capture.frames.mediaframereaderacquisitionmode),  frames that arrive while the app's **FrameArrived** event handler is executing are buffered in memory by the system. The **FrameArrived** event is raised for each buffered frame when the event handler for the previous frame has completed. This mode is intended for apps for which the sequence of frames is critical and for which dropped frames will break the scenario. Note that once the system's memory limit for buffered frames has been reached, no more frames will be acquired until the app processes buffered frames, freeing memory for the acquisition of additional frames.

## -see-also
[MediaFrameReaderAcquisitionMode](/uwp/api/windows.media.capture.frames.mediaframereaderacquisitionmode)

## -examples

