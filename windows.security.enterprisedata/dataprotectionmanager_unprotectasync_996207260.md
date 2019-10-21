---
-api-id: M:Windows.Security.EnterpriseData.DataProtectionManager.UnprotectAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.BufferProtectUnprotectResult> UnprotectAsync(Windows.Storage.Streams.IBuffer data)
-->

# Windows.Security.EnterpriseData.DataProtectionManager.UnprotectAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Removes the protection to an enterprise identity from a buffer.

## -parameters
### -param data
The buffer to be unprotected.

## -returns
When the call to this method completes successfully, it returns a [BufferProtectUnprotectResult](bufferprotectunprotectresult.md) object that contains the status of the unprotected buffer.

## -remarks
UnprotectAsync never returns a status of **Unprotected** since it requires that the input resource be protected. (It is not possible to reliably verify that a resource is unprotected.) If your app compares the result to **Unprotected**, it contains a design flaw because it implies that it lost track of whether the buffer is protected.

## -examples

## -see-also


## -capabilities
enterpriseDataPolicy
