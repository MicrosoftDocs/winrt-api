---
-api-id: P:Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.DsaSha1
-api-type: winrt property
---

<!-- Property syntax
public string DsaSha1 { get; }
-->

# Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.DsaSha1

## -description
Retrieves a string that contains "DSA_SHA1".

## -property-value
String that contains "DSA_SHA1".

## -remarks
Use the string retrieved by this property to set the asymmetric algorithm name when you call the [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm.md) method. The string represents a Digital Signature Algorithm (DSA) that uses the Secure Hashing Algorithm 1 (SHA1) to hash the message contents before signing. The length of the hash is 160 bits.

## -examples

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)