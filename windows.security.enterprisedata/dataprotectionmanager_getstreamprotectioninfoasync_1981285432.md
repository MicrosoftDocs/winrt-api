---
-api-id: M:Windows.Security.EnterpriseData.DataProtectionManager.GetStreamProtectionInfoAsync(Windows.Storage.Streams.IInputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.DataProtectionInfo> GetStreamProtectionInfoAsync(Windows.Storage.Streams.IInputStream protectedStream)
-->

# Windows.Security.EnterpriseData.DataProtectionManager.GetStreamProtectionInfoAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Get the status of an enterprise protected stream.

## -parameters
### -param protectedStream
The stream for which protection status is being queried.

## -returns
When the call to this method completes successfully, it returns a [DataProtectionInfo](dataprotectioninfo.md) object that contains the status of the stream.

## -remarks

## -examples

## -see-also
[DataProtectionInfo](dataprotectioninfo.md)

## -capabilities
enterpriseDataPolicy