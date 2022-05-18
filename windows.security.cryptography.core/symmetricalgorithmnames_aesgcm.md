---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.AesGcm
-api-type: winrt property
---

<!-- Property syntax
public string AesGcm { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.AesGcm

## -description
Retrieves a string that contains "AES_GCM".

## -property-value
String that contains "AES_GCM".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm_637226074.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Advanced Encryption Standard (AES) algorithm coupled with the Galois Counter Mode (GCM) mode of operation.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)
