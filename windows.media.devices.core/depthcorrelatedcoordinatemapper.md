---
-api-id: T:Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper
-api-type: winrt class
---

<!-- Class syntax.
public class DepthCorrelatedCoordinateMapper : Windows.Foundation.IClosable, Windows.Media.Devices.Core.IDepthCorrelatedCoordinateMapper
-->

# Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper

## -description

Maps 2D points in a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) to 3D space or to a frame from a different **MediaFrameSource** using data from a [DepthMediaFrame](../windows.media.capture.frames/depthmediaframe.md).

## -remarks

Get an instance of this class by calling the [TryCreateCoordinateMapper](../windows.media.capture.frames/depthmediaframe_trycreatecoordinatemapper.md) of a [DepthMediaFrame](../windows.media.capture.frames/depthmediaframe.md).

## -examples

## -see-also

[IClosable](../windows.foundation/iclosable.md), [Camera stream correlation sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraStreamCorrelation)