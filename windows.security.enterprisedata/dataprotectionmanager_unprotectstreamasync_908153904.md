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
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Removes the protection to an enterprise identity from a stream of data.

## -parameters

### -param protectedStream

The input, protected stream.

### -param unprotectedStream

The output, unprotected stream.

## -returns

When the call to this method completes successfully, it returns a [DataProtectionInfo](dataprotectioninfo.md) object that contains the status of the unprotected stream.

## -remarks

See the remarks in the [UnprotectStreamAsync](dataprotectionmanager_unprotectasync_996207260.md) method.

## -examples

## -see-also

[DataProtectionInfo](dataprotectioninfo.md)

## -capabilities

enterpriseDataPolicy
