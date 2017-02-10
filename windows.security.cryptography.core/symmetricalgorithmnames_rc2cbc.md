---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.Rc2Cbc
-api-type: winrt property
---

<!-- Property syntax
public string Rc2Cbc { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricAlgorithmNames.Rc2Cbc

## -description
Retrieves a string that contains "RC2_CBC".

## -property-value
String that contains "RC2_CBC".

## -remarks
Use the string retrieved by this property to set the symmetric encryption algorithm name when you call the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm.md) method on a [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) object. The string represents the Rivest Cipher (RC2) block cipher algorithm coupled with a cipher-block chaining mode of operation.

## -examples

## -see-also
[SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)