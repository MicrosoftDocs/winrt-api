---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.DeriveKeyMaterial(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Security.Cryptography.Core.KeyDerivationParameters,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IBuffer DeriveKeyMaterial(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Security.Cryptography.Core.KeyDerivationParameters parameters, System.UInt32 desiredKeySize)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.DeriveKeyMaterial

## -description
Derives a key from another key by using a key derivation function. For more information, see the [KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md) and [KeyDerivationParameters](keyderivationparameters.md) classes.

## -parameters
### -param key
The symmetric or secret key used for derivation.

### -param parameters
Derivation parameters. The parameters vary depending on the type of KDF algorithm used.

### -param desiredKeySize
Requested size, in bytes, of the derived key.

## -returns
Buffer that contains the derived key.

## -remarks
Deriving keys requires that you use the [KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md) and [KeyDerivationParameters](keyderivationparameters.md) classes. The following key derivation functions can be used:
+ [BuildForPbkdf2](keyderivationparameters_buildforpbkdf2.md)
+ [BuildForSP800108](keyderivationparameters_buildforsp800108.md)
+ [BuildForSP80056a](keyderivationparameters_buildforsp80056a.md)


For a complete sample that contains the following code example, see the [KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md) class.

## -examples


[!code-csharp[ShowDerivationFromPbkdf](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowDerivationFromPbkdf)]

## -see-also
[KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md), [KeyDerivationParameters](keyderivationparameters.md)