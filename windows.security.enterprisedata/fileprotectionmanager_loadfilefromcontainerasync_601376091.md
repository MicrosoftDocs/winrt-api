---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.LoadFileFromContainerAsync(Windows.Storage.IStorageFile,Windows.Storage.IStorageItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectedContainerImportResult> LoadFileFromContainerAsync(Windows.Storage.IStorageFile containerFile, Windows.Storage.IStorageItem target)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.LoadFileFromContainerAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Create an enterprise-protected file in a specified storage item (such as a folder), and load it from a container file.

## -parameters

### -param containerFile

The enterprise protected file to be created and loaded.

### -param target

The storage item into which to create the enterprise protected file.

## -returns

When the call to this method completes successfully, it returns a [ProtectedContainerImportResult](protectedcontainerimportresult.md) object representing the newly created protected file.

## -remarks

## -examples

## -see-also

[LoadFileFromContainerAsync(IStorageFile)](fileprotectionmanager_loadfilefromcontainerasync_1464544117.md), [ProtectedContainerImportResult](protectedcontainerimportresult.md)

## -capabilities

enterpriseDataPolicy
