---
-api-id: P:Windows.Security.EnterpriseData.FileProtectionInfo.IsProtectWhileOpenSupported
-api-type: winrt property
---

<!-- Property syntax.
public bool IsProtectWhileOpenSupported { get; }
-->

# Windows.Security.EnterpriseData.FileProtectionInfo.IsProtectWhileOpenSupported

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Determines whether your app can protect a file while it is open.

## -property-value

**true** if your app can protect a file while it is open, or **false** if that capability is not supported on the device.

## -remarks

If this property returns **true**, you can protect a file while the file is open.

This can be useful if users open a file that is not protected and attempt to paste enterprise protected information into it. You can protect the open file and save users from having to respond to a prompt or, depending on the level of policy enforcement, save them from being blocked from pasting content completely.

## -see-also

## -examples
