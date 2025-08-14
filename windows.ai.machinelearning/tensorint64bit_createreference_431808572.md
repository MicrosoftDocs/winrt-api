---
-api-id: M:Windows.AI.MachineLearning.TensorInt64Bit.CreateReference
-api-type: winrt method
ms.custom: 19H1
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Method syntax.
public [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) TensorInt64Bit.CreateReference()
-->

# Windows.AI.MachineLearning.TensorInt64Bit.CreateReference

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Returns an [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) representation of the buffer backing the 64-bit signed integer tensor object.

## -returns
The [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) representation of a tensor buffer.

## -remarks
All [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) objects produced by this method must be closed prior to the 64-bit signed integer tensor object's evaluation.

Outstanding [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) objects are an indication to the engine that the underlying buffer is currently being modified via the **IMemoryBufferByteAccess** native interop interface, and is not ready for evaluation.

## -see-also

## -examples
