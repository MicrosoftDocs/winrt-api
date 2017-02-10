---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.GetProtectionInfoAsync(Windows.Storage.IStorageItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.FileProtectionInfo> GetProtectionInfoAsync(Windows.Storage.IStorageItem source)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.GetProtectionInfoAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Get the status of an enterprise-protected file.

## -parameters
### -param source
The file or folder for which protection status is being queried.

## -returns
When the call to this method completes successfully, it returns a [FileProtectionInfo](fileprotectioninfo.md) object that contains the status of the file.

## -remarks

## -examples

## -see-also
[FileProtectionInfo](fileprotectioninfo.md)

## -capabilities
enterpriseDataPolicy