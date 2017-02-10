---
-api-id: M:Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.ImportPfxDataAsync(System.String,System.String,Windows.Security.Cryptography.Certificates.PfxImportParameters)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ImportPfxDataAsync(System.String pfxData, System.String password, Windows.Security.Cryptography.Certificates.PfxImportParameters pfxImportParameters)
-->

# Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.ImportPfxDataAsync

## -description
Asynchronously imports a certificate from a Personal Information Exchange (PFX) message using import parameters.

## -parameters
### -param pfxData
Base64-encoded PFX message.

### -param password
The password used to decrypt and verify the PFX packet. The password must be exactly the same as the password that was used to encrypt the packet.

### -param pfxImportParameters
The PFX import parameters.

## -returns
This method does not return a value.

## -remarks

## -examples

## -see-also
[ImportPfxDataAsync(String, String, ExportOption, KeyProtectionLevel, InstallOptions, String, String)](certificateenrollmentmanager_importpfxdataasync_2003079147.md), [ImportPfxDataAsync(String, String, ExportOption, KeyProtectionLevel, InstallOptions, String)](certificateenrollmentmanager_importpfxdataasync_387631083.md)