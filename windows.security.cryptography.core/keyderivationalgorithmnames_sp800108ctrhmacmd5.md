---
-api-id: P:Windows.Security.Cryptography.Core.KeyDerivationAlgorithmNames.Sp800108CtrHmacMd5
-api-type: winrt property
---

<!-- Property syntax
public string Sp800108CtrHmacMd5 { get; }
-->

# Windows.Security.Cryptography.Core.KeyDerivationAlgorithmNames.Sp800108CtrHmacMd5

## -description
Retrieves a string that contains "SP800_108_CTR_HMAC_MD5".

## -property-value
String that contains "SP800_108_CTR_HMAC_MD5".

## -remarks
Use the string retrieved by this property to set the Key Derivation Function (KDF) name when you call the [OpenAlgorithm](keyderivationalgorithmprovider_openalgorithm.md) method on the [KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md) class. The string represents an Sp800-108 algorithm in counter mode that uses a Hashed Message Authentication Code based on the MD5 digest algorithm (HmacMd5) as the underlying pseudorandom function.

To use this KDF, you must specify the appropriate parameters by calling the [BuildForSP800108](keyderivationparameters_buildforsp800108.md) method on the [KeyDerivationParameters](keyderivationparameters.md) before calling the [CreateKey](keyderivationalgorithmprovider_createkey.md) method to derive a key.

## -examples

## -see-also
[KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md), [KeyDerivationParameters](keyderivationparameters.md)