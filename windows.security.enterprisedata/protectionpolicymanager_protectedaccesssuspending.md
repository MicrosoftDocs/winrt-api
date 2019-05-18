---
-api-id: E:Windows.Security.EnterpriseData.ProtectionPolicyManager.ProtectedAccessSuspending
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler ProtectedAccessSuspending<Windows.Security.EnterpriseData.ProtectedAccessSuspendingEventArgs>
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.ProtectedAccessSuspending

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Event with which the app registers to receive notification that protection is to be suspended.

## -remarks
An app that is designed to handle enterprise content must make sure that it does not keep any sensitive data in memory. To ensure this, it registers for the ProtectedAccessSuspending and [ProtectedAccessResumed](protectionpolicymanager_protectedaccessresumed.md) events to be notified when, for instance, the device is locked or unlocked. ProtectedAccessSuspending is fired before data protection keys provisioned on the device are temporarily removed. These keys are removed when the device is locked in order to prevent unauthorized access to encrypted data while the device is locked. [ProtectedAccessResumed](protectionpolicymanager_protectedaccessresumed.md) is fired once the keys are available again upon device unlock. When the device is locked, the app makes sure that it protects any sensitive content in memory with the [DataProtectionManager](dataprotectionmanager.md). It also closes open file handles to its protected files to ensure that the system does not cache any sensitive data in memory.

## -examples

## -see-also
[ProtectedAccessResumed](protectionpolicymanager_protectedaccessresumed.md), [DataProtectionManager](dataprotectionmanager.md)

## -capabilities
enterpriseDataPolicy
