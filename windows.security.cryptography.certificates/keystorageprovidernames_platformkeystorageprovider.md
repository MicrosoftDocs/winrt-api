---
-api-id: P:Windows.Security.Cryptography.Certificates.KeyStorageProviderNames.PlatformKeyStorageProvider
-api-type: winrt property
---

<!-- Property syntax
public string PlatformKeyStorageProvider { get; }
-->

# Windows.Security.Cryptography.Certificates.KeyStorageProviderNames.PlatformKeyStorageProvider

## -description
Returns "Microsoft Platform Crypyto Key Storage Provider" as the provider name.

## -property-value
The provider name.

## -remarks

## -examples
```csharp
public void SampleKspNames()
{
    // Create a new CertificateRequestProperties object.
    CertificateRequestProperties reqProperties = new CertificateRequestProperties();

    // Retrieve the default value ("Microsoft Software Key Storage Provider").
    String strDefaultName = reqProperties.KeyStorageProviderName;

    // Set the value to "Microsoft Platform Crypyto Key Storage Provider".
    reqProperties.KeyStorageProviderName = KeyStorageProviderNames.PlatformKeyStorageProvider;

    // Set the value to "Microsoft Smart Card Key Storage Provider".
    reqProperties.KeyStorageProviderName = KeyStorageProviderNames.SmartcardKeyStorageProvider;
}
```



## -see-also
