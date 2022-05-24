---
-api-id: E:Windows.Media.Capture.Frames.MultiSourceMediaFrameReader.FrameArrived
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler FrameArrived<MultiSourceMediaFrameReader, MultiSourceMediaFrameArrivedEventArgs>
-->

# Windows.Media.Capture.Frames.MultiSourceMediaFrameReader.FrameArrived

## -description
Occurs when a new frame arrives from all of the media frame sources associated with the [MultiSourceMediaFrameReader](multisourcemediaframereader.md).

## -remarks
In the handler for the **FrameArrived** event, call [TryAcquireLatestFrame](mediaframereader_tryacquirelatestframe_612769713.md) on the [MultiSourceMediaFrameReference](./multisourcemediaframereference.md) passed in as the sender parameter to the event handler to get a [MultiSourceMediaFrameReference](multisourcemediaframereference.md) representing the latest set of correlated frames from the media frame sources for which the reader was created. Then, get the time-correlated media frame from a particular media frame source by calling [TryGetFrameReferenceBySourceId](./multisourcemediaframereference_trygetframereferencebysourceid_1428642806.md) and passing in the value of the [MediaFrameSourceInfo.Id](./mediaframesourceinfo_id.md) property for the desired media frame source.

Note that this event is only raised when a new frame is available from all of the media frame sources associated with the [MultiSourceMediaFrameReader](multisourcemediaframereader.md). For example, if one of the sources produces frames at twice the rate of another, half of the frames from the faster source will be dropped and this event will only be raised when the slower frame source has a new frame available.  For this reason, it's a good idea to set up an event and signal it each time this event is raised. In a separate thread, you can check to see if the event has been signaled within a specified time window, 5 seconds for example. If the event has not been signaled with the time window, your app can deduce that one of the frame sources is no longer generating frames and that the reader should be stopped. 

For how-to guidance on working with time-correlated media frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).


## -see-also
[Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)

## -examples

