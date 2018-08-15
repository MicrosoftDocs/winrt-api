---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.Rc2Ecb
-api-type: winrt property
---

<!-- Property syntax
public string Rc2Ecb { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.Rc2Ecb

## -description
Retrieves a string that contains "RC2_ECB".

## -property-value
String that contains "RC2_ECB".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm_637226074.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Rivest Cipher (RC2) block cipher algorithm coupled with an electronic codebook (ECB) mode of operation.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)