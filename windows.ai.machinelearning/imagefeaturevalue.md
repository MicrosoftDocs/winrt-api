---
-api-id: T:Windows.AI.MachineLearning.ImageFeatureValue
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class ImageFeatureValue : ILearningModelFeatureValue
-->

# Windows.AI.MachineLearning.ImageFeatureValue

## -description
Describes the properties of the image used to pass into a model.

## -remarks
This is the recommended way of passing images as inputs and outputs. It allows you to focus on the image and not have to worry about either conversions or tensorization. You can create an **ImageFeatureValue** using the [ImageFeatureValue.CreateFromVideoFrame](imagefeaturevalue_createfromvideoframe_748588531.md) method.

Windows ML supports two types of [VideoFrame](../windows.media/videoframe.md): [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) and [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md). The system takes care of both conversion and tensorization for the images to match the format the model requires. The currently supported model format types are Gray8, Rgb8, and Bgr8, and the currently supported pixel range is 0-255.

## -see-also
[Windows ML](https://docs.microsoft.com/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples
The following example creates a [LearningModelSession](learningmodelsession.md) and a [LearningModelBinding](learningmodelbinding.md), binds the input to an **ImageFeatureValue** created from a **VideoFrame**, and then binds the output.

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
```
