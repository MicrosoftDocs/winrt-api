---
-api-id: P:Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaOaepSha256
-api-type: winrt property
---

<!-- Property syntax
public string RsaOaepSha256 { get; }
-->

# Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaOaepSha256

## -description
Retrieves a string that contains "RSA_OAEP_SHA256".

## -property-value
String that contains "RSA_OAEP_SHA256".

## -remarks
Use the string retrieved by this property to set the asymmetric algorithm name when you call the [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm_637226074.md) method. The string represents an RSA algorithm that uses Optimal Asymmetric Encryption Padding (OAEP) to encode or pad the plaintext and a Secure Hashing Algorithm (SHA) to hash the message contents before signing. The length of the SHA hash is 256 bits.

## -examples

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)