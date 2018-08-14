---
-api-id: M:Windows.Security.Cryptography.DataProtection.DataProtectionProvider.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax
public DataProtectionProvider(System.String protectionDescriptor)
-->

# Windows.Security.Cryptography.DataProtection.DataProtectionProvider.DataProtectionProvider

## -description
Constructor used for encryption operations. Use this constructor before calling the [ProtectAsync](dataprotectionprovider_protectasync_124965623.md) or [ProtectStreamAsync](dataprotectionprovider_protectstreamasync_2066668264.md) methods.

## -parameters
### -param protectionDescriptor
Contains the protection descriptor that determines the entity to which the data will be encrypted. For more information, see Remarks.

## -remarks
Do not use this constructor before starting a decryption operation. You must use the [DataProtectionProvider()](dataprotectionprovider_dataprotectionprovider_1221375020.md) constructor instead.

For security descriptors and SDDL strings, you must set the enterprise authentication capability in the manifest. The enterprise authentication capability is restricted to apps built with company accounts, and is subject to additional onboarding validation. You should avoid the enterprise authentication capability unless it is absolutely necessary.
For example, the following SID and SDDL providers require the enterprise authentication capability:

+ "SID=S-1-5-21-4392301 AND SID=S-1-5-21-3101812"
+ "SDDL=O:S-1-5-5-0-290724G:SYD:(A;;CCDC;;;S-1-5-5-0-290724)(A;;DC;;;WD)"

These providers do not require the enterprise authentication capability on either platform:

+ "LOCAL=user"
+ "LOCAL=machine"

These providers do not require the enterprise authentication capability on Windows:

+ "WEBCREDENTIALS=MyPasswordName"
+ "WEBCREDENTIALS=MyPasswordName,myweb.com"


## -examples

## -see-also
[DataProtectionProvider()](dataprotectionprovider_dataprotectionprovider_1221375020.md)