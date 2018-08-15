---
-api-id: P:Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.DsaSha256
-api-type: winrt property
---

<!-- Property syntax
public string DsaSha256 { get; }
-->

# Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.DsaSha256

## -description
Retrieves a string that contains "DSA_SHA256".

## -property-value
String that contains "DSA_SHA256".

## -remarks
Use the string retrieved by this property to set the asymmetric algorithm name when you call the [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm_637226074.md) method. The string represents a Digital Signature Algorithm (DSA) that uses the Secure Hashing Algorithm (SHA) to hash the message contents before signing. The length of the hash is 256 bits.

## -examples

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)