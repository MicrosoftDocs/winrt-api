---
-api-id: M:Windows.Security.EnterpriseData.FileRevocationManager.GetStatusAsync(Windows.Storage.IStorageItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.FileProtectionStatus> GetStatusAsync(Windows.Storage.IStorageItem storageItem)
-->

# Windows.Security.EnterpriseData.FileRevocationManager.GetStatusAsync

## -description
> [!NOTE]
> [FileRevocationManager](filerevocationmanager.md) may be unavailable for releases after Windows 10. Instead, use [FileProtectionManager](fileprotectionmanager.md).



> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Gets the selective wipe protection status for a file or folder.

## -parameters
### -param storageItem
The file or folder to get the selective wipe protection status for.

## -returns
An aysnchronous operation that retrieves the selective wipe protection status for the *storageItem*.

## -remarks
You can use the GetStatusAsync method to determine the Selective Wipe protection status of a file or folder. This will tell you if a file is protected or not, if a file is protected by another user on the computer, and so on. A common use of the GetStatusAsync method is to determine when a protected file should be deleted. For example, when a protected file is revoked, an attempt to access the file contents will result in an "Access is denied" exception. When you encounter that exception, you can use the GetStatusAsync method to determine if the file has been revoked by Selective Wipe and then delete the file if it has, as shown in the following example.



[!code-csharp[_Global](../windows.security.enterprisedata/code/SelectiveWipeSnippets/cs/MainPage.xaml.cs#Snippet_Global)]

[!code-csharp[_GetStatus](../windows.security.enterprisedata/code/SelectiveWipeSnippets/cs/MainPage.xaml.cs#Snippet_GetStatus)]

## -examples

## -see-also
[FileRevocationManager sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/File%20Revocation%20Manager%20Sample), [How to protect files with Selective Wipe  (C#/VB/C++)](/previous-versions/windows/apps/dn456782(v=win.10))
