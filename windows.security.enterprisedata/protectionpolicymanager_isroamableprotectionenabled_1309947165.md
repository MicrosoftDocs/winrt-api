---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.IsRoamableProtectionEnabled(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsRoamableProtectionEnabled(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.IsRoamableProtectionEnabled

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Determines whether the policy is configured to protect files that are copied to removable drives by using [Azure Information Protection](https://www.microsoft.com/cloud-platform/azure-information-protection).

## -parameters

### -param identity

The enterprise identity.

## -returns

**true** if files will be protected by using RMS keys, otherwise **false**.

## -remarks

If this method returns **false**, files that users copy to removable drives will be protected by using local keys and those files won't be accessible on those drives to other users on the current device or, if the drive is connected to another device, to anyone on that newly connected device.  If this method returns **false**, you could (optionally) let users know about this limitation by presenting this information in a dialog box.

## -examples

## -see-also
