---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.CreateCurrentThreadNetworkContext(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.EnterpriseData.ThreadNetworkContext CreateCurrentThreadNetworkContext(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.CreateCurrentThreadNetworkContext

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Creates a [ThreadNetworkContext](threadnetworkcontext.md) protected to an enterprise identity. The creation of the context tags all network connections made thereafter on the current thread with the identity, and allows access to enterprise resources that are access controlled by the enterprise's policy.

## -parameters

### -param identity

The enterprise identity. This is an email address or domain that is managed. This may be returned from [GetPrimaryManagedIdentityForNetworkEndpoint](protectionpolicymanager_getprimarymanagedidentityfornetworkendpointasync_9146700.md); otherwise your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

## -returns

The protected network context. The app must call [ThreadNetworkContext.Close](threadnetworkcontext_close_811482585.md) after access to the resource is completed.

## -remarks

## -examples

## -see-also

[GetPrimaryManagedIdentityForNetworkEndpoint](protectionpolicymanager_getprimarymanagedidentityfornetworkendpointasync_9146700.md), [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md), [ThreadNetworkContext.Close](threadnetworkcontext_close_811482585.md)

## -capabilities

enterpriseDataPolicy
