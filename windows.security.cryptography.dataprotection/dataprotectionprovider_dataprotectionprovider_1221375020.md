---
-api-id: M:Windows.Security.Cryptography.DataProtection.DataProtectionProvider.#ctor
-api-type: winrt method
---

<!-- Method syntax
public DataProtectionProvider()
-->

# Windows.Security.Cryptography.DataProtection.DataProtectionProvider.DataProtectionProvider

## -description
Constructor used for decryption operations. Use this constructor before calling the [UnprotectAsync](dataprotectionprovider_unprotectasync_996207260.md) or [UnprotectStreamAsync](dataprotectionprovider_unprotectstreamasync_908153904.md) methods.

## -remarks
Use this constructor before starting a decryption operation. Do not use this constructor before starting an encryption operation. Use the [DataProtectionProvider(String)](dataprotectionprovider_dataprotectionprovider_290278668.md) method instead.

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

## -see-also
[DataProtectionProvider(String)](dataprotectionprovider_dataprotectionprovider_290278668.md)