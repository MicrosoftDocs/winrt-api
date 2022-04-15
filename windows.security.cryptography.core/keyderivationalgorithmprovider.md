---
-api-id: T:Windows.Security.Cryptography.Core.KeyDerivationAlgorithmProvider
-api-type: winrt class
---

<!-- Class syntax.
public class KeyDerivationAlgorithmProvider : Windows.Security.Cryptography.Core.IKeyDerivationAlgorithmProvider
-->

# Windows.Security.Cryptography.Core.KeyDerivationAlgorithmProvider

## -description
Represents a key derivation algorithm provider.

## -remarks
When two or more parties share a secret symmetric key, it is often necessary to derive additional keys for use in cryptographic operations. It is also often necessary for a trusted third party to derive distinct cryptographic keys from a single master key. Key derivation functions are used to derive these additional keys.

You can use the static [DeriveKeyMaterial](cryptographicengine_derivekeymaterial_1370645582.md) method in the [CryptographicEngine](cryptographicengine.md) class and the following methods in the [KeyDerivationParameters](keyderivationparameters.md) class to derive a key.

| Method | Description |
|---|---|
| [BuildForPbkdf2](keyderivationparameters_buildforpbkdf2_636237279.md) | Creates a [KeyDerivationParameters](keyderivationparameters.md) object for use in the password-based key derivation function 2 (PBKDF2). |
| [BuildForSP800108](keyderivationparameters_buildforsp800108_1459175055.md) | Creates a [KeyDerivationParameters](keyderivationparameters.md) object for use in a counter mode, hash-based message authentication code (HMAC) key derivation function. |
| [BuildForSP80056a](keyderivationparameters_buildforsp80056a_870294687.md) | Creates a [KeyDerivationParameters](keyderivationparameters.md) object for use in the SP800-56A key derivation function. |

You create a KeyDerivationAlgorithmProvider object by calling the static [OpenAlgorithm](keyderivationalgorithmprovider_openalgorithm_637226074.md) method.

## -examples


[!code-csharp[KdfAlgClassOverview](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#KdfAlgClassOverview)]

## -see-also
[CryptographicEngine](cryptographicengine.md), [KeyDerivationParameters](keyderivationparameters.md)
