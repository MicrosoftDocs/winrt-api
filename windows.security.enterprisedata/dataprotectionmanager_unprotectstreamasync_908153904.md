---
-api-id: M:Windows.Security.EnterpriseData.DataProtectionManager.UnprotectStreamAsync(Windows.Storage.Streams.IInputStream,Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.DataProtectionInfo> UnprotectStreamAsync(Windows.Storage.Streams.IInputStream protectedStream, Windows.Storage.Streams.IOutputStream unprotectedStream)
-->

# Windows.Security.EnterpriseData.DataProtectionManager.UnprotectStreamAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Removes the protection to an enterprise identity from a stream of data.

## -parameters
### -param protectedStream
The input, protected stream.

### -param unprotectedStream
The output, unprotected stream.

## -returns
When the call to this method completes successfully, it returns a [DataProtectionInfo](dataprotectioninfo.md) object that contains the status of the unprotected stream.

## -remarks
See the remarks in the [UnprotectStreamAsync](dataprotectionmanager_unprotectasync.md) method.

## -examples

## -see-also
[DataProtectionInfo](dataprotectioninfo.md)

## -capabilities
enterpriseDataPolicy