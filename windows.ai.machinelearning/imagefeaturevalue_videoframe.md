---
-api-id: P:Windows.AI.MachineLearning.ImageFeatureValue.VideoFrame
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public VideoFrame VideoFrame { get; }
-->

# Windows.AI.MachineLearning.ImageFeatureValue.VideoFrame

## -description
Gets the video frame.

## -property-value
The video frame.

## -remarks

## -see-also

## -examples
The following trivial example shows how you could create an [ImageFeatureValue](imagefeaturevalue.md) from a [VideoFrame](../windows.media/videoframe.md), and then later how you could get the **VideoFrame** from which an **ImageFeatureValue** was created.

```cpp
ImageFeatureValue CreateInputFeature(VideoFrame videoFrame)
{
	ImageFeatureValue imageFeatureValue{ ImageFeatureValue::CreateFromVideoFrame(videoFrame) };
	return imageFeatureValue;
}

VideoFrame GetVideoFrame(ImageFeatureValue imageFeatureValue)
{
	VideoFrame videoFrame{ imageFeatureValue.VideoFrame() };
	return videoFrame;
}
```
