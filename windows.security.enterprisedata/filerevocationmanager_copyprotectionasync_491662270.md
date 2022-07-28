---
-api-id: M:Windows.Security.EnterpriseData.FileRevocationManager.CopyProtectionAsync(Windows.Storage.IStorageItem,Windows.Storage.IStorageItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> CopyProtectionAsync(Windows.Storage.IStorageItem sourceStorageItem, Windows.Storage.IStorageItem targetStorageItem)
-->

# Windows.Security.EnterpriseData.FileRevocationManager.CopyProtectionAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

> [!NOTE]
> [FileRevocationManager](filerevocationmanager.md) may be unavailable for releases after Windows 10. Instead, use [FileProtectionManager](fileprotectionmanager.md).

Copy the selective wipe protection state of a file or folder to a new file or folder.

## -parameters

### -param sourceStorageItem

The source item to copy the selective wipe protection status from.

### -param targetStorageItem

The target item to copy the selective wipe protection status to.

## -returns

**true** if the copy operation was successful; otherwise **false**.

## -remarks

If you save a new copy of a file as the result of a "save as" operation, the selective wipe protection status is not copied with the file. To protect the file, you must call the CopyProtectionAsync method to copy the existing protection status to the new file. If you copy a protected file using the [CopyAsync](../windows.storage/istoragefile_copyasync_1709017142.md) or [CopyAndReplaceAsync](../windows.storage/istoragefile_copyandreplaceasync_177558079.md) methods, the selective wipe protection status is copied with the file and you do not need to call the CopyProtectionAsync method.

[!code-csharp[_CopyProtection](../windows.security.enterprisedata/code/SelectiveWipeSnippets/cs/MainPage.xaml.cs#Snippet_CopyProtection)]

The CopyProtectionAsync method requires exclusive access to the file or folder being encrypted, and will fail if another process is using has a handle open to the file or folder.

## -examples

## -see-also

[FileRevocationManager sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/File%20Revocation%20Manager%20Sample), [How to protect files with Selective Wipe  (C#/VB/C++)](/previous-versions/windows/apps/dn456782(v=win.10))
