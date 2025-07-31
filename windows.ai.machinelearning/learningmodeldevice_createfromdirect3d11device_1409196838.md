---
-api-id: M:Windows.AI.MachineLearning.LearningModelDevice.CreateFromDirect3D11Device(Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice)
-api-type: winrt method
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Method syntax.
public LearningModelDevice LearningModelDevice.CreateFromDirect3D11Device(IDirect3DDevice device)
-->

# Windows.AI.MachineLearning.LearningModelDevice.CreateFromDirect3D11Device

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Create a [LearningModelDevice](learningmodeldevice.md) from the specified [IDirect3DDevice](../windows.graphics.directx.direct3d11/idirect3ddevice.md).

## -parameters
### -param device
The **IDirect3DDevice** from which to create a **LearningModelDevice**.

## -returns
A **LearningModelDevice** created from the specified **IDirect3DDevice**.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
