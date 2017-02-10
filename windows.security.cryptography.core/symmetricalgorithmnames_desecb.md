---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.DesEcb
-api-type: winrt property
---

<!-- Property syntax
public string DesEcb { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.DesEcb

## -description
Retrieves a string that contains "DES_ECB".

## -property-value
String that contains "DES_ECB".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Data Encryption Standard (DES) algorithm coupled with an electronic codebook (ECB) mode of operation.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)