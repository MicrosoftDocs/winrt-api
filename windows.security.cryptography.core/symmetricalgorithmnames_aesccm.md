---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.AesCcm
-api-type: winrt property
---

<!-- Property syntax
public string AesCcm { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.AesCcm

## -description
Retrieves a string that contains "AES_CCM".

## -property-value
String that contains "AES_CCM".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Advanced Encryption Standard (AES) algorithm coupled with a CCM (Counter with CBC-MAC) mode of operation.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)