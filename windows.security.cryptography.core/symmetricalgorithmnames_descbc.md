---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.DesCbc
-api-type: winrt property
---

<!-- Property syntax
public string DesCbc { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.DesCbc

## -description
Retrieves a string that contains "DES_CBC".

## -property-value
String that contains "DES_CBC".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm_637226074.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Data Encryption Standard (DES) algorithm coupled with a cipher-block chaining mode of operation.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)