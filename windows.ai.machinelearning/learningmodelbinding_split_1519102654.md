---
-api-id: M:Windows.AI.MachineLearning.LearningModelBinding.Split(Windows.Foundation.Collections.IMapView{System.String,System.Object}@,Windows.Foundation.Collections.IMapView{System.String,System.Object}@)
-api-type: winrt method
---

<!-- Method syntax.
public void LearningModelBinding.Split(IMapView<Object> first, IMapView<Object> second)
-->

# Windows.AI.MachineLearning.LearningModelBinding.Split

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Splits the map view into two views.

## -parameters
### -param first
One half of the original map.

### -param second
The second half of the original map.

## -remarks
The two views that result from the split operation may not contain the same number of items. The two views do not overlap.

If the map view cannot be split, then both the first and second parameters are **null** when the method returns.

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples

