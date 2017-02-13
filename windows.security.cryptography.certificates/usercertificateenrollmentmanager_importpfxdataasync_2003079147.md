---
-api-id: M:Windows.Security.Cryptography.Certificates.UserCertificateEnrollmentManager.ImportPfxDataAsync(System.String,System.String,Windows.Security.Cryptography.Certificates.ExportOption,Windows.Security.Cryptography.Certificates.KeyProtectionLevel,Windows.Security.Cryptography.Certificates.InstallOptions,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ImportPfxDataAsync(System.String pfxData, System.String password, Windows.Security.Cryptography.Certificates.ExportOption exportable, Windows.Security.Cryptography.Certificates.KeyProtectionLevel keyProtectionLevel, Windows.Security.Cryptography.Certificates.InstallOptions installOption, System.String friendlyName, System.String keyStorageProvider)
-->

# Windows.Security.Cryptography.Certificates.UserCertificateEnrollmentManager.ImportPfxDataAsync

## -description
Asynchronously imports a certificate from a Personal Information Exchange (PFX) message using the specified key storage provider.

## -parameters
### -param pfxData
Base64-encoded PFX message.

### -param password
The password used to decrypt and verify the PFX packet. The password must be exactly the same as the password that was used to encrypt the packet.

### -param exportable
A value of the [ExportOption](exportoption.md) enumeration that specifies whether the key can be exported.

### -param keyProtectionLevel
A value of the [KeyProtectionLevel](keyprotectionlevel.md) enumeration that specifies the strength of the key protection. The default is **NoConsent**.

### -param installOption
An [InstallOptions](installoptions.md) enumeration value that specifies the certificate installation option.

### -param friendlyName
The display name of the enrolled certificate. This value overwrites the **FriendlyName** property inside the PFX message.

### -param keyStorageProvider
The name of the key storage provider to use when importing the certificate.

## -returns
This method does not return a value.

## -remarks

## -examples
The following code imports a pfx-based certificate into the user's "My" store and protects the certificate's private key using the devices Trusted Platform Module (TPM). Note that apps require the `sharedUserCertificates` capability to import PFX files or use certificates from the user's "MY" certificate store.

```csharp
CertificateEnrollmentManager.UserCertificateEnrollmentManager.ImportPfxDataAsync(
    pfxData,
    password,
    ExportOption.NotExportable,
    KeyProtectionLevel.NoConsent,
    InstallOptions.DeleteExpired,
    strFriendlyName,
    KeyStorageProviderNames.PlatformKeyStorageProvider);
```



## -see-also
[ImportPfxDataAsync(String, String, ExportOption, KeyProtectionLevel, InstallOptions, String)](usercertificateenrollmentmanager_importpfxdataasync_387631083.md)