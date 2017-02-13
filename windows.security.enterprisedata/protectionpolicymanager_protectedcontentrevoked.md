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
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Event with which your app registers to receive notification that protection is to be revoked. When your app receives this event, it should determine from [ProtectedContentRevokedEventArgs.Identities](protectedcontentrevokedeventargs_identities.md) which enterprise entities have had protection revoked, and call [RevokeContent](protectionpolicymanager_revokecontent.md) as well as delete any metadata associated with the identity. This event is not raised when your app calls [RevokeContent](protectionpolicymanager_revokecontent.md) to revoke its own access.

## -remarks

## -examples

## -see-also
[RevokeContent](protectionpolicymanager_revokecontent.md), [ProtectedContentRevokedEventArgs.Identities](protectedcontentrevokedeventargs_identities.md)

## -capabilities
enterpriseDataPolicy