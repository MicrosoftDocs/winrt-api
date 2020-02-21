---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessToFilesForProcessAsync(Windows.Foundation.Collections.IIterable{Windows.Storage.IStorageItem},System.UInt32,Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ProtectionPolicyEvaluationResult> ProtectionPolicyManager.RequestAccessToFilesForProcessAsync(IIterable<IStorageItem> sourceItemList, UInt32 processId, ProtectionPolicyAuditInfo auditInfo)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessToFilesForProcessAsync


## -description

Requests access to enterprise-protected content for a process of an app.

## -parameters

### -param sourceItemList

An array of files to that you want to grant access to.

### -param processId

The process id of the process that you want to grant the permission to.

### -param auditInfo

An audit info object; an instance of [ProtectionPolicyAuditInfo](protectionpolicyauditinfo.md).

## -returns

A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the query.

## -remarks

## -see-also

## -examples

