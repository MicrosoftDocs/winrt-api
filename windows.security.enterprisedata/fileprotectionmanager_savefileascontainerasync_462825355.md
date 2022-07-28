---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.SaveFileAsContainerAsync(Windows.Storage.IStorageFile,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectedContainerExportResult> SaveFileAsContainerAsync(Windows.Storage.IStorageFile protectedFile, Windows.Foundation.Collections.IIterable<System.String> sharedWithIdentities)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.SaveFileAsContainerAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Save an enterprise-protected file as a containerized version, and share it with a specified list of user identities.

## -parameters

### -param protectedFile

The protected source file being copied.

### -param sharedWithIdentities

A collection of strings representing the user identities to share the containerized file with. For example, email recipients.

## -returns

When the call to this method completes successfully, it returns a [ProtectedContainerExportResult](protectedcontainerexportresult.md) object representing the newly created container file.

## -remarks

## -examples

## -see-also

[SaveFileAsContainerAsync(IStorageFile)](fileprotectionmanager_savefileascontainerasync_116052457.md)
