---
-api-id: M:Windows.AI.MachineLearning.ImageFeatureValue.CreateFromVideoFrame(Windows.Media.VideoFrame)
-api-type: winrt method
---

<!-- Method syntax.
public ImageFeatureValue ImageFeatureValue.CreateFromVideoFrame(VideoFrame image)
-->

# Windows.AI.MachineLearning.ImageFeatureValue.CreateFromVideoFrame

## -description
Creates an [ImageFeatureValue](imagefeaturevalue.md) using the given video frame.

## -parameters
### -param image
The video frame to use to create the **ImageFeatureValue**.

## -returns
The **ImageFeatureValue** created from the given video frame.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
The following example creates a [LearningModelSession](learningmodelsession.md) and a [LearningModelBinding](learningmodelbinding.md), binds the input to an **ImageFeatureValue** created from a [VideoFrame](../windows.media/videoframe.md), and then binds the output.

```cpp
void BindModel(
    LearningModel model, 
    LearningModelDeviceKind deviceKind,
    hstring inputName,
    hstring outputName,
    VideoFrame imageFrame)
{
	// Create a session and binding
	LearningModelSession session = LearningModelSession{ model, LearningModelDevice(deviceKind) };
	LearningModelBinding binding = LearningModelBinding{ session };

	// Bind the intput image
	binding.Bind(inputName, ImageFeatureValue::CreateFromVideoFrame(imageFrame));

	// Bind the output
	vector<int64_t> shape({ 1, 1000, 1, 1 });
	binding.Bind(outputName, TensorFloat::Create(shape));
}
