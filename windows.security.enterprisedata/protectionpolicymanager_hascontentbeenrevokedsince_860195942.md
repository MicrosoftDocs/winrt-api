---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.HasContentBeenRevokedSince(System.String,Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax
public bool HasContentBeenRevokedSince(System.String identity, Windows.Foundation.DateTime since)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.HasContentBeenRevokedSince

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Use this method to check (for a known identity that is managed or ever was managed) whether access to protected data has been revoked since a specified date and time, or is still accessible. Note that the API returns true for an unknown identity (that is, an identity that has never been managed and is not currently managed). This is so that your app can clean up data associated with an identity for which there is no information. For more info, see Remarks.

## -parameters

### -param identity

The enterprise identity protecting the data. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

### -param since

The date and time from which point forward you want to include in the check.

## -returns

**true** if access has been revoked since the specified date and time, otherwise **false**.

## -remarks

Call this API only for an identity that has protected content on the device (in other words, for an identity that has been managed by Windows Information Protection (WIP)). Asking whether content has been revoked for an identity is only meaningful for an identity that has ever been managed by Windows Information Protection (WIP). Consequently, the answer returned from  is meaningful only on the condition that the identity passed to the API has ever been managed by Windows Information Protection (WIP).

We recommend that your app maintains a log of the times it first protected data (files, buffers, or streams) associated with an identity. After this, you should call  only if the identity has protected content associated with it on that device and your app wishes to know whether the protected content was revoked since the time it was protected.

 is not intended to be used as a way to determine whether Windows Information Protection (WIP) was ever enabled and then revoked for an arbitrary identity, in other words as a retrospective-looking form of [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md).

## -examples

## -see-also
