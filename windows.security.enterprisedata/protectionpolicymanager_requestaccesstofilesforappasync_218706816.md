---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessToFilesForAppAsync(Windows.Foundation.Collections.IIterable{Windows.Storage.IStorageItem},System.String,Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ProtectionPolicyEvaluationResult> ProtectionPolicyManager.RequestAccessToFilesForAppAsync(IIterable<IStorageItem> sourceItemList, String appPackageFamilyName, ProtectionPolicyAuditInfo auditInfo)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessToFilesForAppAsync

## -description
Requests access to enterprise-protected content for a specific app.
## -params

## -param sourceItemList
An array of files to that you want to grant access to. 
## -param appPackageFamilyName
The package name of the app that you want to grant permission to.
## -param auditInfo
An audit info object; an instance of [ProtectionPolicyAuditInfo](protectionpolicyauditinfo.md).
## -returns
A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the query. 
## -remarks

## -see-also

## -examples
