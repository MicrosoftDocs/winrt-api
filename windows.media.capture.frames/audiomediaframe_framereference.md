---
-api-id: P:Windows.Media.Capture.Frames.AudioMediaFrame.FrameReference
-api-type: winrt property
---

<!-- Property syntax.
public MediaFrameReference FrameReference { get; }
-->

# Windows.Media.Capture.Frames.AudioMediaFrame.FrameReference

## -description
Gets the [MediaFrameReference](mediaframereference.md) wrapper object associated with the [AudioMediaFrame](audiomediaframe.md), which provides access to format information and other properties of the media frame.

## -property-value
The [MediaFrameReference](mediaframereference.md) wrapper object associated with the [AudioMediaFrame](audiomediaframe.md).

## -remarks
The [TryAcquireLatestFrame](mediaframereader_tryacquirelatestframe_612769713.md) method, which acquires the latest media frame from a [MediaFrameReader](mediaframereader.md), returns a **MediaFrameReference** which is a wrapper class for all types of media frames. If the reference wraps an audio frame, use the [MediaFrameReference.AudioMediaFrame](mediaframereference_audiomediaframe.md) property to get an **AudioMediaFrame** instance. This property lets you get the **MediaFrameReference** object from which the **AudioMediaFrame** was obtained. 

## -see-also
[MediaFrameReference](mediaframereference.md),[MediaFrameReader](mediaframereader.md),[TryAcquireLatestFrame](mediaframereader_tryacquirelatestframe_612769713.md)

## -examples

