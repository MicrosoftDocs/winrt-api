---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RevokeContent(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void RevokeContent(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.RevokeContent

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Revoke the keys required to access all content protected to the specified enterprise identity.

A remote management client on a device receives an unenrollment request from the enterprise’s remote management server, and calls  to revoke the keys that are required to access content protected on that device to that enterprise identity. This causes the [ProtectedContentRevoked](protectionpolicymanager_protectedcontentrevoked.md) event to be raised. Your app can also call  in response to that event, in which case the effect is to revoke your app's access to content protected by itself.

## -parameters

### -param identity

The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

## -remarks

This API is intended for remote device management client apps to call.  requires that all of the following conditions are true for your app.

+ Your app is allowed or running unmanaged through MDM.
+ Your app is either a medium integrity level app (most Win32 apps are medium integrity level), or on a list of UWP apps that can only be configured through Group Policy.
When the enterprise identity that you want to revoke is not managed through MDM, it can still be revoked. The scope of the revoke is different depending on whether the app calling  is a medium (or greater) integrity level app, or a low integrity level app. Examples of low integrity level are Low Rights Internet Explorer (LoRIE), and UWP apps. If the app is medium (or greater) integrity level then it can revoke the keys for all apps. If the app is low integrity level then it can only revoke the key for data that it created itself.

Selective Wipe keys are generated for each UWP app when MDM is not in the picture. This behavior is for compatibility with Windows 8.1, which introduced Selective Wipe.

## -examples

## -see-also

[IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md)

## -capabilities

enterpriseDataPolicy
