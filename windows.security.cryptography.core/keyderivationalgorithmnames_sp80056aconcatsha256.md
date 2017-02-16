---
-api-id: P:Windows.Security.Cryptography.Core.KeyDerivationAlgorithmNames.Sp80056aConcatSha256
-api-type: winrt property
---

<!-- Property syntax
public string Sp80056aConcatSha256 { get; }
-->

# Windows.Security.Cryptography.Core.KeyDerivationAlgorithmNames.Sp80056aConcatSha256

## -description
Retrieves a string that contains "SP800_108_CTR_HMAC_SHA256".

## -property-value
String that contains "SP800_108_CTR_HMAC_SHA256".

## -remarks
Use the string retrieved by this property to set the Key Derivation Function (KDF) name when you call the [OpenAlgorithm](keyderivationalgorithmprovider_openalgorithm.md) method on the [KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md) class. The string represents an Sp800-56a algorithm that uses a Hashed Message Authentication Code (HMAC) based on the SHA256 (Secure Hash Algorithm 256) message digest algorithm as the underlying pseudorandom function.

To use this KDF, you must specify the appropriate parameters by calling the [BuildForSP80056a](keyderivationparameters_buildforsp80056a.md) method on the [KeyDerivationParameters](keyderivationparameters.md) class. The parameters are internally concatenated before the function is used by the [CreateKey](keyderivationalgorithmprovider_createkey.md) method to derive a key.

## -examples

## -see-also
[KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md), [KeyDerivationParameters](keyderivationparameters.md)