---
-api-id: P:Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaSignPkcs1Sha256
-api-type: winrt property
---

<!-- Property syntax
public string RsaSignPkcs1Sha256 { get; }
-->

# Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaSignPkcs1Sha256

## -description
Retrieves a string that contains "RSASIGN_PKCS1_SHA256".

## -property-value
String that contains "RSASIGN_PKCS1_SHA256".

## -remarks
Use the string retrieved by this property to set the asymmetric algorithm name when you call the [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm.md) method. The string represents an RSA signing algorithm that uses PKCS1 to pad the plaintext and the Secure Hashing Algorithm (SHA) to hash the message contents before signing. The length of the SHA hash is 256 bits.

## -examples

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)