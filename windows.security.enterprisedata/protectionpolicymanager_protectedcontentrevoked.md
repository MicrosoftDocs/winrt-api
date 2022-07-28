---
-api-id: E:Windows.Security.EnterpriseData.ProtectionPolicyManager.ProtectedContentRevoked
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler ProtectedContentRevoked<Windows.Security.EnterpriseData.ProtectedContentRevokedEventArgs>
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.ProtectedContentRevoked

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Event with which your app registers to receive notification that protection is to be revoked. When your app receives this event, it should determine from [ProtectedContentRevokedEventArgs.Identities](protectedcontentrevokedeventargs_identities.md) which enterprise entities have had protection revoked, and call [RevokeContent](protectionpolicymanager_revokecontent_41134306.md) as well as delete any metadata associated with the identity. This event is not raised when your app calls [RevokeContent](protectionpolicymanager_revokecontent_41134306.md) to revoke its own access.

## -remarks

## -examples

## -see-also

[RevokeContent](protectionpolicymanager_revokecontent_41134306.md), [ProtectedContentRevokedEventArgs.Identities](protectedcontentrevokedeventargs_identities.md)

## -capabilities

enterpriseDataPolicy
