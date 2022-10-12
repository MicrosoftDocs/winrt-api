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
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

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
