---
-api-id: M:Windows.Security.EnterpriseData.DataProtectionManager.ProtectStreamAsync(Windows.Storage.Streams.IInputStream,System.String,Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.DataProtectionInfo> ProtectStreamAsync(Windows.Storage.Streams.IInputStream unprotectedStream, System.String identity, Windows.Storage.Streams.IOutputStream protectedStream)
-->

# Windows.Security.EnterpriseData.DataProtectionManager.ProtectStreamAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Protect a stream of data to an enterprise identity.

## -parameters
### -param unprotectedStream
The input, unprotected stream.

### -param identity
The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md) to confirm that an email address or domain is managed.

### -param protectedStream
The output, protected stream.

## -returns
When the call to this method completes successfully, it returns a [DataProtectionInfo](dataprotectioninfo.md) object that contains the status of the protected stream.

## -remarks

## -examples

## -see-also
[DataProtectionInfo](dataprotectioninfo.md), [ProtectionPolicyManager.IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md)

## -capabilities
enterpriseDataPolicy
