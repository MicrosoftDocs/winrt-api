---
-api-id: M:Windows.Security.Cryptography.Certificates.UserCertificateEnrollmentManager.CreateRequestAsync(Windows.Security.Cryptography.Certificates.CertificateRequestProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> CreateRequestAsync(Windows.Security.Cryptography.Certificates.CertificateRequestProperties request)
-->

# Windows.Security.Cryptography.Certificates.UserCertificateEnrollmentManager.CreateRequestAsync

## -description
Asynchronously creates a PKCS #10 certificate request based on properties specified in a [CertificateRequestProperties](certificaterequestproperties.md) object.

## -parameters
### -param request
A [CertificateRequestProperties](certificaterequestproperties.md) object that contains the property values used to create the certificate request.

## -returns
An asynchronous operation to retrieve the base64 encoded PKCS #10 certificate request.

## -remarks
Certificate enrollment can be performed in an app container. We recommend that you use the following request objects to submit the request:

+ [XMLHttpRequest](https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest) (JavaScript)
+ [HttpWebRequest](/dotnet/api/system.net.httpwebrequest?view=dotnet-uwp-10.0&preserve-view=true) (C#)
+ [IXMLHTTPRequest](/previous-versions/windows/desktop/ms759148(v=vs.85)) (C++)

The [CertificateRequestProperties](certificaterequestproperties.md) object contains the following default values.

| Property | Default value |
|---|---|
| [Subject](certificaterequestproperties_subject.md) | Empty string |
| [KeyAlgorithmName](certificaterequestproperties_keyalgorithmname.md) | RSA |
| [KeySize](certificaterequestproperties_keysize.md) | 2048 bits |
| [FriendlyName](certificaterequestproperties_friendlyname.md) | Empty String |
| [HashAlgorithmName](certificaterequestproperties_hashalgorithmname.md) | SHA256 |
| [Exportable](certificaterequestproperties_exportable.md) | Not Exportable |
| [KeyUsages](certificaterequestproperties_keyusages.md) | Signing |
| [KeyProtectionLevel](certificaterequestproperties_keyprotectionlevel.md) | NoConsent |
| [KeyStorageProviderName](certificaterequestproperties_keystorageprovidername.md) | Microsoft Software Key Storage Provider |


While the CreateRequestAsync method creates the certificate request, you will need to submit the request to an http enrollment end point. You can then take the response from the http enrollment end point and then call the [InstallCertificateAsync](usercertificateenrollmentmanager_installcertificateasync_225635424.md) method to install the response.

> [!NOTE]
> You must include the **Signing** value in the [KeyUsages](certificaterequestproperties_keyusages.md) property in any [CertificateRequestProperties](certificaterequestproperties.md) object that you use in a call to **CreateRequestAsync**. If you wish to set [KeyUsages](certificaterequestproperties_keyusages.md) to **Decryption** or **KeyAgreement**, you must also OR in **Signing**. Otherwise, the call to **CreateRequestAsync** will fail.

## -examples

## -see-also
[CertificateEnrollmentManager](certificateenrollmentmanager.md)
