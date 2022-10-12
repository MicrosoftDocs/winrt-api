---
-api-id: M:Windows.Security.EnterpriseData.DataProtectionManager.ProtectAsync(Windows.Storage.Streams.IBuffer,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.BufferProtectUnprotectResult> ProtectAsync(Windows.Storage.Streams.IBuffer data, System.String identity)
-->

# Windows.Security.EnterpriseData.DataProtectionManager.ProtectAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Protect the data in a buffer to an enterprise identity.

## -parameters

### -param data

The buffer to be protected.

### -param identity

The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

## -returns

When the call to this method completes successfully, it returns a [BufferProtectUnprotectResult](bufferprotectunprotectresult.md) object that contains the status of the newly protected buffer.

## -remarks

## -examples

## -see-also

[ProtectionPolicyManager.IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md)

## -capabilities

enterpriseDataPolicy
