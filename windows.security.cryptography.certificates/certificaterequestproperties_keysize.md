---
-api-id: P:Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeySize
-api-type: winrt property
---

<!-- Property syntax
public uint KeySize { get;  set; }
-->

# Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeySize

## -description
Gets or sets the size, in bits, of the private key to be generated.

## -property-value
The size, in bits, of the private key.

## -remarks
The default key size for RSA and DSA algorithms is 2048 bits. If an elliptic curve cryptographic (ECC) algorithm was specified in the [KeyAlgorithmName](certificaterequestproperties_keyalgorithmname.md) property, the key size is ignored.

## -examples


[!code-csharp[ShowKeySize](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowKeySize)]

## -see-also
