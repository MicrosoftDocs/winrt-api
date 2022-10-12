---
-api-id: M:Windows.Security.EnterpriseData.DataProtectionManager.ProtectStreamAsync(Windows.Storage.Streams.IInputStream,System.String,Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.DataProtectionInfo> ProtectStreamAsync(Windows.Storage.Streams.IInputStream unprotectedStream, System.String identity, Windows.Storage.Streams.IOutputStream protectedStream)
-->

# Windows.Security.EnterpriseData.DataProtectionManager.ProtectStreamAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Protect a stream of data to an enterprise identity.

## -parameters

### -param unprotectedStream

The input, unprotected stream.

### -param identity

The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

### -param protectedStream

The output, protected stream.

## -returns

When the call to this method completes successfully, it returns a [DataProtectionInfo](dataprotectioninfo.md) object that contains the status of the protected stream.

## -remarks

## -examples

## -see-also

[DataProtectionInfo](dataprotectioninfo.md), [ProtectionPolicyManager.IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md)

## -capabilities

enterpriseDataPolicy
