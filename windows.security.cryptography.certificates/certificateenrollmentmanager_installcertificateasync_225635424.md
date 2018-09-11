---
-api-id: M:Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.InstallCertificateAsync(System.String,Windows.Security.Cryptography.Certificates.InstallOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction InstallCertificateAsync(System.String certificate, Windows.Security.Cryptography.Certificates.InstallOptions installOption)
-->

# Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager.InstallCertificateAsync

## -description
Asynchronously Installs a certificate chain into the app container on the local computer.

## -parameters
### -param certificate
The encoded certificate. The *certificate* is encoded by using Distinguished Encoding Rules (DER) as defined by the Abstract Syntax Notation One (ASN.1) standard.

### -param installOption
An [InstallOptions](installoptions.md) enumeration value that specifies the certificate installation option.

## -returns
This method does not return a value.

## -remarks
This method installs the certificate chain into the app container:


+ The certificate request for the input certificate must have been previously generated on the local computer by calling the [CreateRequestAsync](certificateenrollmentmanager_createrequestasync_1910274509.md) method.
+ The certificates included in the response need not be chained to trusted root certificates on the installing computer.
+ The certificate is installed in the app container MY store.
+ Certification authority (CA) and Root certificates are installed in the app container intermediate CA store.


## -examples

## -see-also
