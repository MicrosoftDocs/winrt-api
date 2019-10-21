---
-api-id: T:Windows.Security.EnterpriseData.FileProtectionManager
-api-type: winrt class
---

<!-- Class syntax.
public class FileProtectionManager 
-->

# Windows.Security.EnterpriseData.FileProtectionManager

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Provides access to operations that manage files that are protected to an enterprise identity.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | IsContainerAsync |
| 1511 | 10586 | LoadFileFromContainerAsync(IStorageFile,IStorageItem,NameCollisionOption) |
| 1511 | 10586 | SaveFileAsContainerAsync(IStorageFile,IEnumerable<String>) |
| 1703 | 15063 | UnprotectAsync(IStorageItem) |
| 1703 | 15063 | UnprotectAsync(IStorageItem,FileUnprotectOptions) |

## -examples

## -see-also


## -capabilities
enterpriseDataPolicy
