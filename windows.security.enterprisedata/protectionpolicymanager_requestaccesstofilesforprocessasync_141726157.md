---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessToFilesForProcessAsync(Windows.Foundation.Collections.IIterable{Windows.Storage.IStorageItem},System.UInt32,Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo,System.String,Windows.Security.EnterpriseData.ProtectionPolicyRequestAccessBehavior)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ProtectionPolicyEvaluationResult> ProtectionPolicyManager.RequestAccessToFilesForProcessAsync(IIterable<IStorageItem> sourceItemList, UInt32 processId, ProtectionPolicyAuditInfo auditInfo, String messageFromApp, ProtectionPolicyRequestAccessBehavior behavior)
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

### -param messageFromApp

A message that will be displayed in the consent dialog box so that the user can make a consent decision.

### -param behavior

A constant that defines how you would like to override default policy behavior.

## -returns

A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the query.

## -remarks

Use this method to temporarily grant access of a protected file to a process that can only access unprotected files.

## -see-also

## -examples

