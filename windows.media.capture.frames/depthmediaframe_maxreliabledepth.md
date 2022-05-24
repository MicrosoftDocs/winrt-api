---
-api-id: P:Windows.Media.Capture.Frames.DepthMediaFrame.MaxReliableDepth
-api-type: winrt property
---

<!-- Property syntax.
public uint MaxReliableDepth { get; }
-->

# Windows.Media.Capture.Frames.DepthMediaFrame.MaxReliableDepth

## -description
Gets a value that specifies the maximum reliable depth value for the camera that captured the depth frame.

## -property-value
A value that specifies the maximum reliable depth value for the camera that captured the depth frame.

## -remarks
A depth camera may not be able to reliably sense the depth for the full range of the UInt16 value that is used to express depth in a depth media frame. The value of **MaxReliableDepth** is set by the depth camera device to indicate the upper limit of values within the UInt16 range for which the device can reliably capture depth data. You can safely clamp depth pixel values greater than this value. The lower limit of reliable depth values is specified with the [MinReliableDepth](./depthmediaframe_minreliabledepth.md) property. These properties are expressed in the same units as the individual depth pixel values. You can convert **MaxReliableDepth** to meters by multiplying it by the value of the [DepthScaleInMeters](./depthmediaframeformat_depthscaleinmeters.md) property of the [DepthFormat](./depthmediaframe_depthformat.md) property of the [DepthMediaFrame](./depthmediaframe.md) object.

## -see-also

## -examples

