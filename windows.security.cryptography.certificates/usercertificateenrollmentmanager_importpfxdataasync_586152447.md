---
-api-id: M:Windows.Security.Cryptography.Certificates.UserCertificateEnrollmentManager.ImportPfxDataAsync(System.String,System.String,Windows.Security.Cryptography.Certificates.PfxImportParameters)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ImportPfxDataAsync(System.String pfxData, System.String password, Windows.Security.Cryptography.Certificates.PfxImportParameters pfxImportParameters)
-->

# Windows.Security.Cryptography.Certificates.UserCertificateEnrollmentManager.ImportPfxDataAsync

## -description
Asynchronously imports a certificate from a Personal Information Exchange (PFX) message using the specified import parameters.

## -parameters
### -param pfxData
Base64-encoded PFX message.

### -param password
he password used to decrypt and verify the PFX packet. The password must be exactly the same as the password that was used to encrypt the packet.

### -param pfxImportParameters
The import parameters.

## -returns
This method does not return a value.

## -remarks

## -examples

## -see-also
[ImportPfxDataAsync(String, String, ExportOption, KeyProtectionLevel, InstallOptions, String)](usercertificateenrollmentmanager_importpfxdataasync_387631083.md), [ImportPfxDataAsync(String, String, ExportOption, KeyProtectionLevel, InstallOptions, String, String)](usercertificateenrollmentmanager_importpfxdataasync_2003079147.md)