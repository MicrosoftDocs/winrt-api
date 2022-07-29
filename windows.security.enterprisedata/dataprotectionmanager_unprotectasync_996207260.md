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
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

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
