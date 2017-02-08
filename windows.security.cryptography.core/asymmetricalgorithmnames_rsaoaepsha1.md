---
-api-id: P:Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaOaepSha1
-api-type: winrt property
---

<!-- Property syntax
public string RsaOaepSha1 { get; }
-->

# Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaOaepSha1

## -description
Retrieves a string that contains "RSA_OAEP_SHA1".

## -property-value
String that contains "RSA_OAEP_SHA1".

## -remarks
Use the string retrieved by this property to set the asymmetric algorithm name when you call the [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm.md) method. The string represents an RSA algorithm that uses Optimal Asymmetric Encryption Padding (OAEP) to encode or pad the plaintext and a Secure Hashing Algorithm (SHA) to hash the message contents before signing. The length of the SHA1 hash is 160 bits.

## -examples

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)