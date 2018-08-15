---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.TripleDesCbc
-api-type: winrt property
---

<!-- Property syntax
public string TripleDesCbc { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.TripleDesCbc

## -description
Retrieves a string that contains "3DES_CBC".

## -property-value
String that contains "3DES_CBC".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm_637226074.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Triple Data Encryption Standard (TripleDES) algorithm coupled with a cipher-block chaining mode of operation. This implementation of TripleDES is a three-key implementation, which requires a key size of 24 bytes. Passing a key size less than 24 bytes to this algorithm's [CreateSymmetricKey](symmetrickeyalgorithmprovider_createsymmetrickey_199420845.md) method produces a "Value does not fall within the expected range" exception.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)