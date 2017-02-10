---
-api-id: P:Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaSignPssSha384
-api-type: winrt property
---

<!-- Property syntax
public string RsaSignPssSha384 { get; }
-->

# Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames.RsaSignPssSha384

## -description
Retrieves a string that contains "RSASIGN_PSS_SHA384".

## -property-value
String that contains "RSASIGN_PSS_SHA384".

## -remarks
Use the string retrieved by this property to set the asymmetric algorithm name when you call the [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm.md) method. The string represents an RSA signing algorithm that uses the Probabilistic Signature Scheme (PSS) to pad the plaintext and the Secure Hashing Algorithm (SHA) to hash the message contents before signing. The length of the SHA hash is 384 bits.

## -examples

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)