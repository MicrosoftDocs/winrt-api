---
-api-id: T:Windows.AI.MachineLearning.TensorFloat
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class TensorFloat : ILearningModelFeatureValue, ITensor
-->

# Windows.AI.MachineLearning.TensorFloat

## -description
A 32-bit float tensor object.

## -remarks
A tensor is a multi-dimensional array of values. A float tensor is a tensor of 32-bit floating point values.

The layout of tensors is row-major, with tightly packed contiguous data representing each dimension. The total size of a tensor is the product of the size of each dimension.

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also
[Windows ML](https://docs.microsoft.com/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples
The following example creates a session and a binding, binds the input image, and then binds the output to a created **TensorFloat**:

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

	// Bind the input image
	binding.Bind(inputName, ImageFeatureValue::CreateFromVideoFrame(imageFrame));

	// Bind the output
	vector<int64_t> shape({ 1, 1000, 1, 1 });
	binding.Bind(outputName, TensorFloat::Create(shape));
}
```
