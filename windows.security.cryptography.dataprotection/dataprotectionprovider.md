---
-api-id: T:Windows.Security.Cryptography.DataProtection.DataProtectionProvider
-api-type: winrt class
---

<!-- Class syntax.
public class DataProtectionProvider : Windows.Security.Cryptography.DataProtection.IDataProtectionProvider
-->

# Windows.Security.Cryptography.DataProtection.DataProtectionProvider

## -description
Represents a cryptographic provider that can be used to asynchronously encrypt and decrypt static data or a data stream.

## -remarks
You can use the class to protect data to any of the following:


+ You can use a security descriptor (SID) or a security descriptor definition language (SDDL) string to protect data to an Active Directory (AD) security principal such as an AD group. Any member of the group can decrypt the data.
+ You can protect data to the local user or computer account.
+ You can protect data to the credentials (password) used during logon to a website.


For security descriptors and SDDL strings, you must set the enterprise authentication capability in the manifest. The enterprise authentication capability is restricted to UWP app built with company accounts, and is subject to additional onboarding validation. You should avoid the enterprise authentication capability unless it is absolutely necessary. For more information, see [Registering for a  developer account](/windows/uwp/publish/opening-a-developer-account).
For example, the following SID and SDDL providers require the enterprise authentication capability:

+ "SID=S-1-5-21-4392301 AND SID=S-1-5-21-3101812"
+ "SDDL=O:S-1-5-5-0-290724G:SYD:(A;;CCDC;;;S-1-5-5-0-290724)(A;;DC;;;WD)"

These providers do not require the enterprise authentication capability:

+ "LOCAL=user"
+ "LOCAL=machine"
+ "WEBCREDENTIALS=MyPasswordName"
+ "WEBCREDENTIALS=MyPasswordName,myweb.com"


## -examples
The following sample shows how to protect static data.



[!code-csharp[ShowStaticProtection](../windows.security.cryptography.dataprotection/code/ProtectUnprotectAsync/csharp/StaticDataProtectionApp.xaml.cs#SnippetShowStaticProtection)]



[!code-csharp[ShowProtectStream](../windows.security.cryptography.dataprotection/code/ProtectUnprotectStreamAsync/csharp/StreamDataProtectionApp.xaml.cs#SnippetShowProtectStream)]

## -see-also
