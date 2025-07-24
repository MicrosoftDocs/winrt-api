---
-api-id: M:Windows.AI.MachineLearning.TensorInt32Bit.Close
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void TensorInt32Bit.Close()
-->

# Windows.AI.MachineLearning.TensorInt32Bit.Close

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

If there are no outstanding [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) objects created from this object, **Close** will dispose of the object and destroy its associated resources. Otherwise, **Close** will detach itself from its associated resources and they will be destroyed when the last [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) is closed.

## -remarks

## -see-also

## -examples

