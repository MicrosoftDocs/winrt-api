---
-api-id: P:Windows.Media.Capture.Frames.MediaFrameSourceInfo.IsShareable
-api-type: winrt property
---

# Windows.Media.Capture.Frames.MediaFrameSourceInfo.IsShareable

<!--
public bool IsShareable { get; }
-->


## -description

Gets a value indicating whether the associated stream can be open in shared mode.

## -property-value

True if the stream can be opened in shared mode; otherwise, false.

## -remarks

Since not all streams are shareable, it is important for shared mode application that has stream selection requirement to verify that the selected stream is shareable.

## -see-also

## -examples


