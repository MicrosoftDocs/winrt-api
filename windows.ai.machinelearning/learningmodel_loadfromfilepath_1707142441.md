---
-api-id: M:Windows.AI.MachineLearning.LearningModel.LoadFromFilePath(System.String,Windows.AI.MachineLearning.ILearningModelOperatorProvider)
-api-type: winrt method
---

<!-- Method syntax.
public LearningModel LearningModel.LoadFromFilePath(String filePath, ILearningModelOperatorProvider operatorProvider)
-->

# Windows.AI.MachineLearning.LearningModel.LoadFromFilePath

## -description
Loads an ONNX model from a file on disk.

## -parameters

### -param filePath
The path to the ONNX model file on disk.

### -param operatorProvider

## -returns
An object representing the model.

## -remarks
This method is meant for desktop (non-UWP) applications. For UWP, see [LoadFromStorageFileAsync](learningmodel_loadfromstoragefileasync_532232733.md).

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples

