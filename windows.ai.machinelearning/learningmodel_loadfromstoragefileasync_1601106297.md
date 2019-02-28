---
-api-id: M:Windows.AI.MachineLearning.LearningModel.LoadFromStorageFileAsync(Windows.Storage.IStorageFile,Windows.AI.MachineLearning.ILearningModelOperatorProvider)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<LearningModel> LearningModel.LoadFromStorageFileAsync(IStorageFile modelFile, ILearningModelOperatorProvider operatorProvider)
-->

# Windows.AI.MachineLearning.LearningModel.LoadFromStorageFileAsync

## -description
Loads an ONNX model from an [IStorageFile](../windows.storage/istoragefile.md) asynchronously.

## -parameters
### -param modelFile
The location of the model file.

### -param operatorProvider

## -returns
A [LearningModel](learningmodel.md) based on the model file.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples

