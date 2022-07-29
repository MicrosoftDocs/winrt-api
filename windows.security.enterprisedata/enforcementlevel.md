---
-api-id: T:Windows.Security.EnterpriseData.EnforcementLevel
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.EnterpriseData.EnforcementLevel : int
-->

# EnforcementLevel

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

A set of enumerated values together describing the possible Windows Information Protection (WIP) enforcement levels. WIP enforcement level is one aspect of mobile device management (MDM) policy configuration.

## -enum-fields

### -field NoProtection:0

The policy calls for no protection. Your app should disable WIP behavior if data is protected, and unprotect data.

### -field Silent:1

The policy calls for silent protection. Your app should not prompt in response to an action such as pasting data into an unauthorized app. Instead, your app should silently allow the action, and audit it.

### -field Override:2

The policy calls for the user to be allowed to override a warning message. In response to an attempted action such as pasting data into an unauthorized app, your app should prompt the user via an overridable warning message. If the user overrides, then your app should perform the action and audit it.

### -field Block:3

The policy calls for the user to be blocked. In response to an attempted action such as pasting data into an unauthorized app, your app should block the action, and audit it.

## -remarks

## -examples

## -see-also
