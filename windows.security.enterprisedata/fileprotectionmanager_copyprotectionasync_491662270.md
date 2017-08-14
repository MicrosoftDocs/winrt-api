---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.CopyProtectionAsync(Windows.Storage.IStorageItem,Windows.Storage.IStorageItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> CopyProtectionAsync(Windows.Storage.IStorageItem source, Windows.Storage.IStorageItem target)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.CopyProtectionAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Replicate the file protection of one file onto another file.

## -parameters
### -param source
The source file, from which file protection is being copied.

### -param target
The target file, to which file protection is being copied.

## -returns
When the call to this method completes successfully, it returns **true** if the file protection was copied, or **false** if there was an error.

## -remarks

## -examples

## -see-also


## -capabilities
enterpriseDataPolicy
