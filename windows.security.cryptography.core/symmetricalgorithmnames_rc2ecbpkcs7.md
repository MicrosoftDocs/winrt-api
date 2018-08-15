---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.Rc2EcbPkcs7
-api-type: winrt property
---

<!-- Property syntax
public string Rc2EcbPkcs7 { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.Rc2EcbPkcs7

## -description
Retrieves a string that contains "RC2_ECB_PKCS7".

## -property-value
String that contains "RC2_ECB_PKCS7".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm_637226074.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Rivest Cipher (RC2) block cipher algorithm coupled with an electronic codebook (ECB) mode of operation and PKCS#7 padding.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)