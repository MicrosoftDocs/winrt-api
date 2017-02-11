---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.TripleDesEcb
-api-type: winrt property
---

<!-- Property syntax
public string TripleDesEcb { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.TripleDesEcb

## -description
Retrieves a string that contains "3DES_ECB".

## -property-value
String that contains "3DES_ECB".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Triple Data Encryption Standard (TripleDES) algorithm coupled with an electronic codebook (ECB) mode of operation.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)