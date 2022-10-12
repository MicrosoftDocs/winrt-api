---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.IsUserDecryptionAllowed(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsUserDecryptionAllowed(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.IsUserDecryptionAllowed

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Use this property to determine whether decryption of files protected by Windows Information Protection (WIP) is allowed.

## -parameters

### -param identity

The enterprise identity you want to check has access to the protected content.

## -returns

**true** if decryption of files protected by WIP is allowed, otherwise **false**.

## -remarks

## -examples

## -see-also
