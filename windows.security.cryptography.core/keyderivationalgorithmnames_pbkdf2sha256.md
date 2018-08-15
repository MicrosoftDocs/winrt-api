---
-api-id: P:Windows.Security.Cryptography.Core.KeyDerivationAlgorithmNames.Pbkdf2Sha256
-api-type: winrt property
---

<!-- Property syntax
public string Pbkdf2Sha256 { get; }
-->

# Windows.Security.Cryptography.Core.KeyDerivationAlgorithmNames.Pbkdf2Sha256

## -description
Retrieves a string that contains "PBKDF2_SHA256".

## -property-value
String that contains "PBKDF2_SHA256".

## -remarks
Use the string retrieved by this property to set the Key Derivation Function (KDF) name when you call the [OpenAlgorithm](keyderivationalgorithmprovider_openalgorithm_637226074.md) method on the [KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md) class. The string represents a Password-Based Key Derivation Function 2 (PBKDF2) algorithm that uses a Hashed Message Authentication Code (HMAC) based on the SHA256 (Secure Hash Algorithm 256) message digest algorithm as the underlying pseudorandom function.

To use this KDF, you must specify the appropriate salt value and iteration count by calling the [BuildForPbkdf2](keyderivationparameters_buildforpbkdf2_636237279.md) method on the [KeyDerivationParameters](keyderivationparameters.md) class before calling the [CreateKey](keyderivationalgorithmprovider_createkey_928231294.md) method to derive a key.

## -examples

## -see-also
[KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md), [KeyDerivationParameters](keyderivationparameters.md)