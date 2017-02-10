---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.TripleDesCbcPkcs7
-api-type: winrt property
---

<!-- Property syntax
public string TripleDesCbcPkcs7 { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.TripleDesCbcPkcs7

## -description
Retrieves a string that contains "3DES_CBC_PKCS7".

## -property-value
String that contains "3DES_CBC_PKCS7".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Triple Data Encryption Standard (TripleDES) algorithm coupled with a cipher-block chaining mode of operation and PKCS#7 padding.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)