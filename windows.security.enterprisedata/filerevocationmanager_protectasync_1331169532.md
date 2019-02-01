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
You can use the [ProtectAsync](filerevocationmanager_protectasync_1331169532.md) method to protect a file or folder using Selective Wipe. This identifies the file as protected for your enterprise identifier, such as "example.com", as shown in the previous code example. If you protect a folder using the [ProtectAsync](filerevocationmanager_protectasync_1331169532.md) method, then all files in that folder inherit the same protection.



[!code-csharp[_Global](../windows.security.enterprisedata/code/SelectiveWipeSnippets/cs/MainPage.xaml.cs#Snippet_Global)]

[!code-csharp[_Protect](../windows.security.enterprisedata/code/SelectiveWipeSnippets/cs/MainPage.xaml.cs#Snippet_Protect)]

[!code-js[_Global_JS](../windows.security.enterprisedata/code/SelectiveWipeSnippets/js/default.js#Snippet_Global_JS)]

[!code-js[_Protect_JS](../windows.security.enterprisedata/code/SelectiveWipeSnippets/js/default.js#Snippet_Protect_JS)]

The [ProtectAsync](filerevocationmanager_protectasync_1331169532.md) method requires exclusive access to the file or folder being encrypted, and will fail if another process is using has a handle open to the file or folder.

## -examples

## -see-also
[FileRevocationManager sample](https://go.microsoft.com/fwlink/p/?LinkID=299023), [How to protect files with Selective Wipe  (C#/VB/C++)](https://msdn.microsoft.com/library/a1afb4fb-6731-461a-8dd2-51eec5e880a1), [How to protect files with Selective Wipe (JavaScript)](https://msdn.microsoft.com/library/5b8652eb-6462-4bf1-b5b7-4a37957c605f)
