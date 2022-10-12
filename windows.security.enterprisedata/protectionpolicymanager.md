---
-api-id: T:Windows.Security.EnterpriseData.ProtectionPolicyManager
-api-type: winrt class
---

<!-- Class syntax.
public class ProtectionPolicyManager : Windows.Security.EnterpriseData.IProtectionPolicyManager, Windows.Security.EnterpriseData.IProtectionPolicyManager2
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Manages enterprise-protection policy on protected content.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | CheckAccessForApp |
| 1511 | 10586 | GetEnforcementLevel |
| 1511 | 10586 | HasContentBeenRevokedSince |
| 1511 | 10586 | IsProtectionEnabled |
| 1511 | 10586 | IsProtectionUnderLockRequired |
| 1511 | 10586 | IsUserDecryptionAllowed |
| 1511 | 10586 | PolicyChanged |
| 1511 | 10586 | RequestAccessForAppAsync(String,String) |
| 1607 | 14393 | LogAuditEvent |
| 1607 | 14393 | RequestAccessAsync(String,String,ProtectionPolicyAuditInfo) |
| 1607 | 14393 | RequestAccessAsync(String,String,ProtectionPolicyAuditInfo,String) |
| 1607 | 14393 | RequestAccessForAppAsync(String,String,ProtectionPolicyAuditInfo) |
| 1607 | 14393 | RequestAccessForAppAsync(String,String,ProtectionPolicyAuditInfo,String) |
| 1607 | 14393 | ShowEnterpriseIndicator |
| 1703 | 15063 | GetPrimaryManagedIdentityForIdentity |
| 1703 | 15063 | IsFileProtectionRequiredAsync |
| 1703 | 15063 | IsFileProtectionRequiredForNewFileAsync |
| 1703 | 15063 | IsRoamableProtectionEnabled |
| 1703 | 15063 | PrimaryManagedIdentity |
| 1703 | 15063 | RequestAccessAsync(String,String,ProtectionPolicyAuditInfo,String,ProtectionPolicyRequestAccessBehavior) |
| 1703 | 15063 | RequestAccessForAppAsync(String,String,ProtectionPolicyAuditInfo,String,ProtectionPolicyRequestAccessBehavior) |
| 1703 | 15063 | RequestAccessToFilesForAppAsync(IEnumerable&lt;IStorageItem&gt;,String,ProtectionPolicyAuditInfo) |
| 1703 | 15063 | RequestAccessToFilesForAppAsync(IEnumerable&lt;IStorageItem&gt;,String,ProtectionPolicyAuditInfo,String,ProtectionPolicyRequestAccessBehavior) |
| 1703 | 15063 | RequestAccessToFilesForProcessAsync(IEnumerable&lt;IStorageItem&gt;,UInt32,ProtectionPolicyAuditInfo) |
| 1703 | 15063 | RequestAccessToFilesForProcessAsync(IEnumerable&lt;IStorageItem&gt;,UInt32,ProtectionPolicyAuditInfo,String,ProtectionPolicyRequestAccessBehavior) |

## -examples

## -see-also

## -capabilities

enterpriseDataPolicy
