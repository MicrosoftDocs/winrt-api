---
-api-id: P:Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.EcdsaP521Sha512
-api-type: winrt property
---

<!-- Property syntax
public string EcdsaP521Sha512 { get; }
-->

# Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.EcdsaP521Sha512

## -description
Retrieves a string that contains "ECDSA_P521_SHA512".

## -property-value
String that contains "ECDSA_P521_SHA512".

## -remarks
Use the string retrieved by this property to set the asymmetric algorithm name when you call the [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm_637226074.md) method. The string represents an Elliptic Curve Digital Signature Algorithm (ECDSA) that uses a 521-bit public key and a Secure Hashing Algorithm (SHA) to hash the message contents before signing. The length of the hash is 512 bits.

> [!NOTE]
> You must specify a value of 521 when calling the [CreateKeyPair](asymmetrickeyalgorithmprovider_createkeypair_920965104.md) method to create keys that are compatible with this algorithm.

## -examples

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)
