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
> [FileRevocationManager](filerevocationmanager.md) may be unavailable for releases after Windows 10. Instead, use [FileProtectionManager](fileprotectionmanager.md).



> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Revokes all files and folders protected for selective wipe for a specified enterprise id.

## -parameters
### -param enterpriseIdentity
Revoke all files and folders protected by selective wipe for this enterprise id. The *enterpriseIdentity* value must be formatted as an Internationalized Domain Name (IDN) and cannot contain spaces. For example, **contoso.com**.

## -remarks
When your app determines that a user is no longer valid, you can quickly revoke access to all of the files and folders protected for an enterprise identity using the [Revoke](filerevocationmanager_revoke.md) method, as shown in the following example. The file is not deleted by the [Revoke](filerevocationmanager_revoke.md) method. The [Revoke](filerevocationmanager_revoke.md) method puts the file into state where it cannot be accessed. You can add code to your app to delete a file that is inaccessible and has been revoked.

## -examples

## -see-also
[FileRevocationManager sample](http://go.microsoft.com/fwlink/p/?LinkID=299023), [How to protect files with Selective Wipe  (C#/VB/C++)](http://msdn.microsoft.com/library/a1afb4fb-6731-461a-8dd2-51eec5e880a1), [How to protect files with Selective Wipe (JavaScript)](http://msdn.microsoft.com/library/5b8652eb-6462-4bf1-b5b7-4a37957c605f)