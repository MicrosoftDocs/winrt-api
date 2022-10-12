---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.GetPrimaryManagedIdentityForNetworkEndpointAsync(Windows.Networking.HostName)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetPrimaryManagedIdentityForNetworkEndpointAsync(Windows.Networking.HostName endpointHost)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.GetPrimaryManagedIdentityForNetworkEndpointAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Returns the enterprise identity of a network resource if the resource is on an enterprise-policy-managed endpoint.

## -parameters

### -param endpointHost

The host name or IP address of the network resource.

## -returns

The enterprise identity.

## -remarks

## -examples

## -see-also

## -capabilities

enterpriseDataPolicy
