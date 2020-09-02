---
-api-id: M:Windows.Security.Cryptography.DataProtection.DataProtectionProvider.UnprotectAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> UnprotectAsync(Windows.Storage.Streams.IBuffer data)
-->

# Windows.Security.Cryptography.DataProtection.DataProtectionProvider.UnprotectAsync

## -description
Asynchronously decrypts static data.

## -parameters
### -param data
Data to decrypt.

## -returns
Represents an asynchronous operation.

## -remarks
You must call the [DataProtectionProvider()](dataprotectionprovider_dataprotectionprovider_1221375020.md) constructor before calling this method.

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
