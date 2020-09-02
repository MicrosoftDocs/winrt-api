---
-api-id: P:Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeyStorageProviderName
-api-type: winrt property
---

<!-- Property syntax
public string KeyStorageProviderName { get;  set; }
-->

# Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeyStorageProviderName

## -description
Gets or sets the name of the key storage provider (KSP) that will be used to generate the private key.

## -property-value
The KSP name. The default value is "Microsoft Software Key Storage Provider".

## -remarks
The name of a [cryptographic service provider](/windows/desktop/SecGloss/c-gly) ([CSP](/windows/desktop/SecCrypto/cryptographic-service-providers)) cannot be used.

## -examples


[!code-csharp[ShowKspName](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowKspName)]

## -see-also
