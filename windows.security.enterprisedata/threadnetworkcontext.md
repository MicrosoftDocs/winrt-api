---
-api-id: T:Windows.Security.EnterpriseData.ThreadNetworkContext
-api-type: winrt class
---

<!-- Class syntax.
public class ThreadNetworkContext : Windows.Foundation.IClosable, Windows.Security.EnterpriseData.IThreadNetworkContext
-->

# Windows.Security.EnterpriseData.ThreadNetworkContext

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

A protected network context for an enterprise identity. The creation of the context tags all network connections made thereafter on the current thread with the identity, and allows access to enterprise resources that are access controlled by the enterprise's policy.

> [!NOTE]
> Although  is attributed as being agile, [Close](threadnetworkcontext_close.md) (or ) must be called on the originating thread in order to avoid an exception.

## -remarks

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [ProtectionPolicyManager.CreateCurrentThreadNetworkContext](protectionpolicymanager_createcurrentthreadnetworkcontext.md)