---
-api-id: P:Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.EcdsaP256Sha256
-api-type: winrt property
---

<!-- Property syntax
public string EcdsaP256Sha256 { get; }
-->

# Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.EcdsaP256Sha256

## -description
Retrieves a string that contains "ECDSA_P256_SHA256".

## -property-value
String that contains "ECDSA_P256_SHA256".

## -remarks
Use the string retrieved by this property to set the asymmetric algorithm name when you call the [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm.md) method. The string represents an Elliptic Curve Digital Signature Algorithm (ECDSA) that uses a 256-bit public key and a Secure Hashing Algorithm (SHA) to hash the message contents before signing. The length of the hash is 256 bits.

> [!NOTE]
> You must specify a value of 256 when calling the [CreateKeyPair](asymmetrickeyalgorithmprovider_createkeypair.md) method to create keys that are compatible with this algorithm.

## -examples

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)