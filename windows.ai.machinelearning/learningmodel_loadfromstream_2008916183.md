---
-api-id: M:Windows.AI.MachineLearning.LearningModel.LoadFromStream(Windows.Storage.Streams.IRandomAccessStreamReference,Windows.AI.MachineLearning.ILearningModelOperatorProvider)
-api-type: winrt method
---

<!-- Method syntax.
public LearningModel LearningModel.LoadFromStream(IRandomAccessStreamReference modelStream, ILearningModelOperatorProvider operatorProvider)
-->

# Windows.AI.MachineLearning.LearningModel.LoadFromStream

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Loads an ONNX model from a stream.

## -parameters
### -param modelStream
The stream from which to load the model.

### -param operatorProvider

## -returns
An object representing the model file.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples

