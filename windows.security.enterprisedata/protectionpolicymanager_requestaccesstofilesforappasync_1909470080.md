---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessToFilesForAppAsync(Windows.Foundation.Collections.IIterable{Windows.Storage.IStorageItem},System.String,Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo,System.String,Windows.Security.EnterpriseData.ProtectionPolicyRequestAccessBehavior)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ProtectionPolicyEvaluationResult> ProtectionPolicyManager.RequestAccessToFilesForAppAsync(IIterable<IStorageItem> sourceItemList, String appPackageFamilyName, ProtectionPolicyAuditInfo auditInfo, String messageFromApp, ProtectionPolicyRequestAccessBehavior behavior)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessToFilesForAppAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Requests access to enterprise-protected content for a specific app.

## -parameters

### -param sourceItemList

An array of files to that you want to grant access to.

### -param appPackageFamilyName

The package name of the app that you want to grant the permission to.

### -param auditInfo

An audit info object; an instance of [ProtectionPolicyAuditInfo](protectionpolicyauditinfo.md).

### -param messageFromApp

A message that will be displayed in the consent dialog box so that the user can make a consent decision.

### -param behavior

A constant that defines how you would like to override default policy behavior.

## -returns

A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the query.

## -remarks

## -see-also

## -examples
