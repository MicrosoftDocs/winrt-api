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
The name of a [cryptographic service provider](http://msdn.microsoft.com/library/db46def4-bfdc-4801-a57d-d568e94a2dbb) ([CSP](http://msdn.microsoft.com/library/4e6eb2df-a917-4533-b9f1-8da39598d0b8)) cannot be used.

## -examples


[!code-csharp[ShowKspName](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowKspName)]

## -see-also
