---
-api-id: P:Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaPkcs1
-api-type: winrt property
---

<!-- Property syntax
public string RsaPkcs1 { get; }
-->

# Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaPkcs1

## -description
Retrieves a string that contains "RSA_PKCS1".

## -property-value
String that contains "RSA_PKCS1".

## -remarks
Use the string retrieved by this property to set the asymmetric algorithm name when you call the [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm.md) method. The string represents an RSA public key algorithm that uses PKCS1 to pad the plaintext. No hash algorithm is used.

## -examples

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)