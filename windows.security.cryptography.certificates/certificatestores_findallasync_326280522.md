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

The follow example enumerates certificates in an App store and adds them to the User store.

``` csharp
public static void AddAppSmartCardCertIntoUserStore()
{
    // Retrieve certificates in App store.
    var certs = await CertificateStores.FindAllAsync();
    // open user Personal store
    UserCertificateStore store = CertificateStores.GetUserStoreByName(StandardCertificateStoreNames.Personal);
    foreach (Certificate cert in certs)
    {
        if (cert.KeyStoreageProviderName == KeyStorageProviderNames.SmartcardKeyStorageProvider &&
            !cert.IsPerUser)
        {
            var added = await store.RequestAddAsync(cert);
            if (!added) break;
        }
    }
}
```

## -see-also

[FindAllAsync(CertificateQuery)](certificatestores_findallasync_1029446703.md)
