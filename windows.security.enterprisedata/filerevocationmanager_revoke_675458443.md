---
-api-id: M:Windows.Security.EnterpriseData.FileRevocationManager.Revoke(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void Revoke(System.String enterpriseIdentity)
-->

# Windows.Security.EnterpriseData.FileRevocationManager.Revoke

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

> [!NOTE]
> [FileRevocationManager](filerevocationmanager.md) may be unavailable for releases after Windows 10. Instead, use [FileProtectionManager](fileprotectionmanager.md).

Revokes all files and folders protected for selective wipe for a specified enterprise id.

## -parameters

### -param enterpriseIdentity

Revoke all files and folders protected by selective wipe for this enterprise id. The *enterpriseIdentity* value must be formatted as an Internationalized Domain Name (IDN) and cannot contain spaces. For example, `contoso.com`.

## -remarks

When your app determines that a user is no longer valid, you can quickly revoke access to all of the files and folders protected for an enterprise identity using the Revoke method, as shown in the following example. The file is not deleted by the Revoke method. The Revoke method puts the file into state where it cannot be accessed. You can add code to your app to delete a file that is inaccessible and has been revoked.

## -examples

## -see-also

[FileRevocationManager sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/File%20Revocation%20Manager%20Sample), [How to protect files with Selective Wipe  (C#/VB/C++)](/previous-versions/windows/apps/dn456782(v=win.10)), [How to protect files with Selective Wipe (JavaScript)](/previous-versions/windows/apps/dn456781(v=win.10))
