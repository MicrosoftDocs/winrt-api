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
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

A protected network context for an enterprise identity. The creation of the context tags all network connections made thereafter on the current thread with the identity, and allows access to enterprise resources that are access controlled by the enterprise's policy.

> [!NOTE]
> Although  is attributed as being agile, [Close](threadnetworkcontext_close_811482585.md) (or ) must be called on the originating thread in order to avoid an exception.

## -remarks

## -examples

## -see-also

[IClosable](../windows.foundation/iclosable.md), [ProtectionPolicyManager.CreateCurrentThreadNetworkContext](protectionpolicymanager_createcurrentthreadnetworkcontext_620400136.md)
