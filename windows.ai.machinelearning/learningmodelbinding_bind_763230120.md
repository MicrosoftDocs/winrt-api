---
-api-id: M:Windows.AI.MachineLearning.LearningModelBinding.Bind(System.String,System.Object,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax.
public void LearningModelBinding.Bind(String name, Object value, IPropertySet props)
-->

# Windows.AI.MachineLearning.LearningModelBinding.Bind

## -description
Bind a value to the named feature using properties to control the binding.

## -parameters
### -param name
The name of the feature to which to bind.

### -param value
The value to bind to the feature.

### -param props
A property map with key-value pairs describing the binding's tensorization and detensorization behavior. For more details, see the **Remarks** section.

## -remarks

These are the valid key-value pairs for the *props* parameter:

Name                  | Value | Description
----------------------|-------|------------------
BitmapBounds          | [PropertyType.UInt32Array](/uwp/api/windows.foundation.propertyvalue.createuint32array) | When binding an input, the BitmapBounds property specifies cropping boundaries. The cropped image will be extracted and used as the input for performing inference.<br><br>When binding an output, the BitmapBounds property specifies boundaries for a target output region. The result of inference will be written to the target output region within the bound image.<br><br>The BitmapBounds property is specified as a UInt32 array with the values `[left, top, width, height]`. <br><br>This property takes effect only when binding an [ImageFeatureValue](/uwp/api/windows.ai.machinelearning.imagefeaturevalue).|
BitmapPixelFormat     | [PropertyType.Int32](/uwp/api/windows.foundation.propertyvalue.createint32) | When binding an input or output, the BitmapPixelFormat property specifies the pixel format intended by the model author for a particular feature value. When the **Image.BitmapPixelFormat** metadata is missing from the ONNX model's [Image metadata](https://github.com/onnx/onnx/blob/main/docs/MetadataProps.md), it can be specified at runtime by using this property. Bound images will be automatically converted to the specified pixel format for consumption by the model. <br><br>The BitmapPixelFormat must be specified as an Int32 value corresponding to values in the [Windows.Graphics.Imaging.BitmapPixelFormat](/uwp/api/windows.graphics.imaging.bitmappixelformat) enumeration. Currently the following values are supported:<ul><li>BitmapPixelFormat.Rgba8</li><li>BitmapPixelFormat.Bgra8</li><li>BitmapPixelFormat.Gray8</li></ul>This property takes effect only when binding an [ImageFeatureValue](/uwp/api/windows.ai.machinelearning.imagefeaturevalue).|
DisableTensorCpuSync  | [PropertyType.Boolean](/uwp/api/windows.foundation.propertyvalue.createboolean) | When binding an output tensor backed by an ID3D12Resource, the DisableTensorCpuSync property can be used to prevent copying the GPU/NPU output back to a CPU tensor. By default, the [LearningModelSession.Evaluate](/uwp/api/windows.ai.machinelearning.learningmodelsession_evaluate) API call is a blocking call, and will ensure that inference results are available on the CPU post-completion. <br><br> In certain GPU/NPU evaluation scenarios, it's desirable to keep inference results on the GPU/NPU; and copying the results back to the CPU is unnecessary and slower. To avoid that copy, enable the DisableTensorCpuSync property during binding.<br><br>This property takes effect only when binding an [ITensor](/uwp/api/windows.ai.machinelearning.itensor) or its concrete types (that is, [TensorFloat](/uwp/api/windows.ai.machinelearning.tensorfloat)).<br><br>This property was introduced in Windows 11, version 21H2 (10.0; Build 22000).|
PixelRange            | [PropertyType.Int32](/uwp/api/windows.foundation.propertyvalue.createint32) | When binding an input or output, the PixelRange property specifies the normalization range intended by the model author for a particular feature value. When the **Image.NominalPixelRange** metadata is missing from the ONNX model's [Image metadata](https://github.com/onnx/onnx/blob/main/docs/MetadataProps.md), it can be specified at runtime by using this property. Bound images will be automatically converted to the specified normalized range for consumption by the model. <br><br>The PixelRange must be specified as an Int32 value corresponding to values in the [Windows.AI.MachineLearning.LearningModelPixelRange](/uwp/api/windows.ai.machinelearning.learningmodelpixelrange) enumeration.<br><br>This property takes effect only when binding an [ImageFeatureValue](/uwp/api/windows.ai.machinelearning.imagefeaturevalue).

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -examples

## -see-also
