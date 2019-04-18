---
-api-id: P:Windows.AI.MachineLearning.LearningModelSessionOptions.BatchSizeOverride
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public uint BatchSizeOverride { get;  set; }
-->

# Windows.AI.MachineLearning.LearningModelSessionOptions.BatchSizeOverride

## -description
A numeric value that specifies a constant batch size override value for the target model.

## -property-value
The constant batch size for model inputs feature values expected by calls to [Bind](learningmodelbinding_bind_765850420.md). The default value for the **BatchSizeOverride** will be 1 indicating a static batch size of 1.

## -remarks
The **BatchSizeOverride** option allows the model compiler to use constant batch size performance optimizations when setting up the [LearningModelSession](learningmodelsession.md).

By setting the **BatchSizeOverride** options, all inputs for the session will have their batch sizes restricted to match the specified **BatchSizeOverride** value.

A **BatchSizeOverride** = 0 indicates that the batch size present in the model should be honored without change.

**BatchSizeOverride** > 0 indicates the batch size that will be used to override the model batch size and optimize evaluations.

If model evaluations always happen using the same batch size, performance can be improved by setting the **BatchSizeOverride** to the expected batch size.

Setting the **BatchSizeOverride** parameter will restrict the model's input batch size to a constant batch size, and will enable model compiler optimizations that can improve the runtime performance of calls to [Evaluate](learningmodelsession_evaluate_291797498.md).

If the inference model is designed to accept any batch size, then the **BatchSizeOverride** parameter can be used to restrict batched inputs to a constant batch size.

However, if the inference model is designed with a constant batch size, the **BatchSizeOverride** parameter must match the constant batch size defined in the model.

ONNX models describe the batch dimension of input tensor features using the DATA_BATCH dimension denotation. This corresponds to the N dimension in the more commonly used tensor format notation NCHW.
        

## -see-also

## -examples

