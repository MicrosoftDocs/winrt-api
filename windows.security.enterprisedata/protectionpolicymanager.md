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
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

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
| 1703 | 15063 | RequestAccessToFilesForAppAsync(IEnumerable<IStorageItem>,String,ProtectionPolicyAuditInfo) |
| 1703 | 15063 | RequestAccessToFilesForAppAsync(IEnumerable<IStorageItem>,String,ProtectionPolicyAuditInfo,String,ProtectionPolicyRequestAccessBehavior) |
| 1703 | 15063 | RequestAccessToFilesForProcessAsync(IEnumerable<IStorageItem>,UInt32,ProtectionPolicyAuditInfo) |
| 1703 | 15063 | RequestAccessToFilesForProcessAsync(IEnumerable<IStorageItem>,UInt32,ProtectionPolicyAuditInfo,String,ProtectionPolicyRequestAccessBehavior) |

## -examples

## -see-also


## -capabilities
enterpriseDataPolicy
