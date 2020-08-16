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

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
The following trivial example shows how you could create an [ImageFeatureValue](imagefeaturevalue.md) from a [VideoFrame](../windows.media/videoframe.md), and then later how you could get the **VideoFrame** from which an **ImageFeatureValue** was created.

```cppwinrt
#include <winrt/Windows.AI.MachineLearning.h>
#include <winrt/Windows.Media.h>
using namespace winrt;
using namespace Windows::AI::MachineLearning;
using namespace Windows::Media;

...

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
