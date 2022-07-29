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
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Provides access to operations that manage files that are protected to an enterprise identity.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | IsContainerAsync |
| 1511 | 10586 | LoadFileFromContainerAsync(IStorageFile,IStorageItem,NameCollisionOption) |
| 1511 | 10586 | SaveFileAsContainerAsync(IStorageFile,IEnumerable&lt;String&gt;) |
| 1703 | 15063 | UnprotectAsync(IStorageItem) |
| 1703 | 15063 | UnprotectAsync(IStorageItem,FileUnprotectOptions) |

## -examples

## -see-also

## -capabilities

enterpriseDataPolicy
