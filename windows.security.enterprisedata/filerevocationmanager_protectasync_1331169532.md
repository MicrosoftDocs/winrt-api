---
-api-id: M:Windows.Security.EnterpriseData.FileRevocationManager.ProtectAsync(Windows.Storage.IStorageItem,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.FileProtectionStatus> ProtectAsync(Windows.Storage.IStorageItem storageItem, System.String enterpriseIdentity)
-->

# Windows.Security.EnterpriseData.FileRevocationManager.ProtectAsync

## -description
> [!NOTE]
> [FileRevocationManager](filerevocationmanager.md) may be unavailable for releases after Windows 10. Instead, use [FileProtectionManager](fileprotectionmanager.md).



> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Protects a file or folder for selective wipe.

## -parameters
### -param storageItem
The file or folder to protect for selective wipe.

### -param enterpriseIdentity
The enterprise id that the file or folder is protected for. The *enterpriseIdentity* value must be formatted as an Internationalized Domain Name (IDN) and cannot contain spaces. For example, **contoso.com**.

## -returns
An asynchronous operation that retrieves the selective wipe protection status for the *storageItem*.

## -remarks
You can use the ProtectAsync method to protect a file or folder using Selective Wipe. This identifies the file as protected for your enterprise identifier, such as "example.com", as shown in the previous code example. If you protect a folder using the ProtectAsync method, then all files in that folder inherit the same protection.



[!code-csharp[_Global](../windows.security.enterprisedata/code/SelectiveWipeSnippets/cs/MainPage.xaml.cs#Snippet_Global)]

[!code-csharp[_Protect](../windows.security.enterprisedata/code/SelectiveWipeSnippets/cs/MainPage.xaml.cs#Snippet_Protect)]

[!code-js[_Global_JS](../windows.security.enterprisedata/code/SelectiveWipeSnippets/js/default.js#Snippet_Global_JS)]

[!code-js[_Protect_JS](../windows.security.enterprisedata/code/SelectiveWipeSnippets/js/default.js#Snippet_Protect_JS)]

The ProtectAsync method requires exclusive access to the file or folder being encrypted, and will fail if another process is using has a handle open to the file or folder.

## -examples

## -see-also
[FileRevocationManager sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/File%20Revocation%20Manager%20Sample), [How to protect files with Selective Wipe  (C#/VB/C++)](/previous-versions/windows/apps/dn456782(v=win.10)), [How to protect files with Selective Wipe (JavaScript)](/previous-versions/windows/apps/dn456781(v=win.10))
