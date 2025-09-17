---
-api-id: M:Windows.AI.MachineLearning.TensorString.CreateReference
-api-type: winrt method
ms.custom: 19H1
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Method syntax.
public [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) TensorString.CreateReference()
-->

# Windows.AI.MachineLearning.TensorString.CreateReference

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

This method is disallowed on [TensorString](tensorstring.md) objects and should not be used.

## -returns
The [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) returned is always **null**.

## -remarks
**TensorString** objects do not provide native access to their underlying buffer resources via the [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) and **IMemoryBufferByteAccess** access pattern.

## -see-also

## -examples
