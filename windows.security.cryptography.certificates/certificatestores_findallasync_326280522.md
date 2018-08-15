---
-api-id: M:Windows.Security.Cryptography.Certificates.CertificateStores.FindAllAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Security.Cryptography.Certificates.Certificate>> FindAllAsync()
-->

# Windows.Security.Cryptography.Certificates.CertificateStores.FindAllAsync

## -description
Get all certificates from the certificate stores.

## -returns
An asynchronous operation to retrieve the list of certificates.

## -remarks
The [FindAllAsync](certificatestores_findallasync_1029446703.md) method filters the resulting list of certificates and removes duplicates, showing only the most recent certificate when duplicates are found. This only occurs if the app is running in an app container. Duplicate certificates are certificates that have the same subject and issuer.

Expired certificates are not returned in the list of certificates.

## -examples

## -see-also
[FindAllAsync(CertificateQuery)](certificatestores_findallasync_1029446703.md)