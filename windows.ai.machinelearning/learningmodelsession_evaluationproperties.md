---
-api-id: P:Windows.AI.MachineLearning.LearningModelSession.EvaluationProperties
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IPropertySet EvaluationProperties { get; }
-->

# Windows.AI.MachineLearning.LearningModelSession.EvaluationProperties

## -description

Set of properties that control model evaluation.

## -property-value

Set of properties that control model evaluation.

## -remarks

### Windows Server

To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety

This API is thread-safe.

## -see-also

## -examples

The following example demonstrates how to enable trace log output:

```cppwinrt
#include <winrt/Windows.AI.MachineLearning.h>
using namespace winrt;
using namespace Windows::AI::MachineLearning;

...

void EnableDebugOutput(LearningModelSession _session)
{
    // Enables trace log output.
    _session.EvaluationProperties().Insert(L"EnableDebugOutput", nullptr);
}
```