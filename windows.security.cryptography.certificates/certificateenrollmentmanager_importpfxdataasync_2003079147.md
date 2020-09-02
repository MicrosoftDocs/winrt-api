---
-api-id: M:Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.ImportPfxDataAsync(System.String,System.String,Windows.Security.Cryptography.Certificates.ExportOption,Windows.Security.Cryptography.Certificates.KeyProtectionLevel,Windows.Security.Cryptography.Certificates.InstallOptions,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ImportPfxDataAsync(System.String pfxData, System.String password, Windows.Security.Cryptography.Certificates.ExportOption exportable, Windows.Security.Cryptography.Certificates.KeyProtectionLevel keyProtectionLevel, Windows.Security.Cryptography.Certificates.InstallOptions installOption, System.String friendlyName, System.String keyStorageProvider)
-->

# Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.ImportPfxDataAsync

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
This method imports the certificate chain into the app container.


+ To import an issued certificate, it is not necessary for the certificate request to have been generated on the importing computer.
+ The certificates included in the response need not be chained to trusted root certificates on the importing computer.
+ The certificate is installed in the app container MY store.
+ [Certification authority](/windows/desktop/SecGloss/c-gly) and Root certificates are installed in the app container intermediate [certification authority](/windows/desktop/SecGloss/c-gly) store.
+ The key container name and key specification for the imported certificate are determined as described in the Remarks section of [PFXImportCertStore](/windows/desktop/api/wincrypt/nf-wincrypt-pfximportcertstore) with the exception that if AttributeId 1.3.6.1.4.1.311.17.1 is not present, MS_KEY_STORAGE_PROVIDER is always used as the provider name.


## -examples

## -see-also
[ImportPfxDataAsync(String, String, ExportOption, KeyProtectionLevel, InstallOptions, String)](certificateenrollmentmanager_importpfxdataasync_387631083.md)