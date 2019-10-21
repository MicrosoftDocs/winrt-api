---
-api-id: T:Windows.System.AppResourceGroupInfo
-api-type: winrt class
---

<!-- Class syntax.
public class AppResourceGroupInfo
-->

# Windows.System.AppResourceGroupInfo

## -description
Provides diagnostic information such as memory usage and energy use.

## -remarks
Resource groups allow you to group components for the purposes of resource management. If you don't define a group, you will get at least one by default, and possibly more, depending on whether the app has background tasks.

Resource groups are specified in the manifest with the **ResourceGroup** tag.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | StartResumeAsync |
| 1803 | 17134 | StartSuspendAsync |
| 1803 | 17134 | StartTerminateAsync |

## -see-also

## -examples

## -capabilities
appDiagnostics
