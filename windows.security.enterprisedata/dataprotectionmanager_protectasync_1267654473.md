---
-api-id: M:Windows.Security.EnterpriseData.DataProtectionManager.ProtectAsync(Windows.Storage.Streams.IBuffer,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.BufferProtectUnprotectResult> ProtectAsync(Windows.Storage.Streams.IBuffer data, System.String identity)
-->

# Windows.Security.EnterpriseData.DataProtectionManager.ProtectAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Protect the data in a buffer to an enterprise identity.

## -parameters
### -param data
The buffer to be protected.

### -param identity
The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md) to confirm that an email address or domain is managed.

## -returns
When the call to this method completes successfully, it returns a [BufferProtectUnprotectResult](bufferprotectunprotectresult.md) object that contains the status of the newly protected buffer.

## -remarks

## -examples

## -see-also
[ProtectionPolicyManager.IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md)

## -capabilities
enterpriseDataPolicy