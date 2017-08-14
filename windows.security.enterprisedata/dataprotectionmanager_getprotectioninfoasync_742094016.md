---
-api-id: M:Windows.Security.EnterpriseData.DataProtectionManager.GetProtectionInfoAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.DataProtectionInfo> GetProtectionInfoAsync(Windows.Storage.Streams.IBuffer protectedData)
-->

# Windows.Security.EnterpriseData.DataProtectionManager.GetProtectionInfoAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Get the status of an enterprise protected buffer.

## -parameters
### -param protectedData
The buffer for which protection status is being queried.

## -returns
When the call to this method completes successfully, it returns a [DataProtectionInfo](dataprotectioninfo.md) object that contains the status of the buffer.

## -remarks

## -examples

## -see-also
[DataProtectionInfo](dataprotectioninfo.md)

## -capabilities
enterpriseDataPolicy
