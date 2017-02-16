---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.AesCbc
-api-type: winrt property
---

<!-- Property syntax
public string AesCbc { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.AesCbc

## -description
Retrieves a string that contains "AES_CBC".

## -property-value
String that contains "AES_CBC".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Advanced Encryption Standard (AES) algorithm coupled with a cipher-block chaining mode of operation.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)