---
-api-id: P:Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeyAlgorithmName
-api-type: winrt property
---

<!-- Property syntax
public string KeyAlgorithmName { get;  set; }
-->

# Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeyAlgorithmName

## -description
Gets or sets the public key algorithm.

## -property-value
Algorithm name.

## -remarks
The default value is "RSA". You can use properties on the [KeyAlgorithmNames](keyalgorithmnames.md) class to specify error-free names or to compare the name retrieved by this property with a known string.

## -examples


[!code-csharp[ShowPublicKeyAlg](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowPublicKeyAlg)]

## -see-also
[KeyAlgorithmNames](keyalgorithmnames.md)