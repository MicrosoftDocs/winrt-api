---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.CreateProtectedAndOpenAsync(Windows.Storage.IStorageFolder,System.String,System.String,Windows.Storage.CreationCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectedFileCreateResult> CreateProtectedAndOpenAsync(Windows.Storage.IStorageFolder parentFolder, System.String desiredName, System.String identity, Windows.Storage.CreationCollisionOption collisionOption)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.CreateProtectedAndOpenAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Create an enterprise-protected file.

## -parameters

### -param parentFolder

The folder into which to create the enterprise protected file.

### -param desiredName

The desired name of the new enterprise protected file.

### -param identity

The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

### -param collisionOption

A [CreationCollisionOption](../windows.storage/creationcollisionoption.md) value that specifies what to do if *desiredName* already exists.

## -returns

When the call to this method completes successfully, it returns a [ProtectedFileCreateResult](protectedfilecreateresult.md) object representing the newly created protected file.

## -remarks

## -examples

## -see-also

[CreationCollisionOption](../windows.storage/creationcollisionoption.md), [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md), [ProtectedFileCreateResult](protectedfilecreateresult.md)

## -capabilities

enterpriseDataPolicy
