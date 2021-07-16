---
-api-id: P:Windows.Media.Capture.Frames.DepthMediaFrame.MinReliableDepth
-api-type: winrt property
---

<!-- Property syntax.
public uint MinReliableDepth { get; }
-->

# Windows.Media.Capture.Frames.DepthMediaFrame.MinReliableDepth

## -description
Gets a value that specifies the minimum reliable depth value for the camera that captured the depth frame.

## -property-value
A value that specifies the minimum reliable depth value for the camera that captured the depth frame.

## -remarks
A depth camera may not be able to reliably sense the depth for the full range of the UInt16 value that is used to express depth in a depth media frame. The value of **MinReliableDepth** is set by the depth camera device to indicate the lower limit of values within the UInt16 range for which the device can reliably capture depth data. You can safely clamp depth pixel values lower than this value. The upper limit of reliable depth values is specified with the [MaxReliableDepth](./depthmediaframe_maxreliabledepth.md) property. These properties are expressed in the same units as the individual depth pixel values. You can convert **MinReliableDepth** to meters by multiplying it by the value of the [DepthScaleInMeters](./depthmediaframeformat_depthscaleinmeters.md) property of the [DepthFormat](./depthmediaframe_depthformat.md) property of the [DepthMediaFrame](./depthmediaframe.md) object.

## -see-also

## -examples

