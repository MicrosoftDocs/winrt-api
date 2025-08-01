---
-api-id: T:Windows.AI.MachineLearning.LearningModelSessionOptions
-api-type: winrt class
ms.custom: 19H1
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Class syntax.
public class LearningModelSessionOptions 
-->

# Windows.AI.MachineLearning.LearningModelSessionOptions

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Describes inference options that are used during the creation of [LearningModelSession](learningmodelsession.md) objects.

## -remarks
The **LearningModelSessionOptions** object can be used to configure [LearningModelSession](learningmodelsession.md) construction.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | CloseModelOnSessionCreation |

## -see-also

## -examples
The following example creates a **LearningModelSessionOptions** object for use during session creation.

```csharp
private LearningModelSessionOptions CreateSessionOptions()
{
    var options = new LearningModelSessionOptions();

    // Disable constant batch size optimizations
    options.BatchSizeOverride = 0;

    return options;
}
```
