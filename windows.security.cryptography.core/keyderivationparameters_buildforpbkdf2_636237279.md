---
-api-id: M:Windows.Security.Cryptography.Core.KeyDerivationParameters.BuildForPbkdf2(Windows.Storage.Streams.IBuffer,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.KeyDerivationParameters BuildForPbkdf2(Windows.Storage.Streams.IBuffer pbkdf2Salt, System.UInt32 iterationCount)
-->

# Windows.Security.Cryptography.Core.KeyDerivationParameters.BuildForPbkdf2

## -description
Creates a [KeyDerivationParameters](keyderivationparameters.md) object for use in the password-based key derivation function 2 (PBKDF2).

## -parameters
### -param pbkdf2Salt
The salt, a random or pseudorandom value to be combined with the password in multiple iterations. A salt is used to increase entropy above what can be obtained from using a password alone.

### -param iterationCount
Number of iterations to be used to derive a key.

## -returns
Refers to the parameters used during key derivation.

## -remarks
You can use the following algorithm names with the [OpenAlgorithm](keyderivationalgorithmprovider_openalgorithm_637226074.md) function to open a PBKDF2 algorithm provider:


+ [KeyDerivationAlgorithmNames.Pbkdf2Md5](keyderivationalgorithmnames_pbkdf2md5.md)
+ [KeyDerivationAlgorithmNames.Pbkdf2Sha1](keyderivationalgorithmnames_pbkdf2sha1.md)
+ [KeyDerivationAlgorithmNames.Pbkdf2Sha256](keyderivationalgorithmnames_pbkdf2sha256.md)
+ [KeyDerivationAlgorithmNames.Pbkdf2Sha384](keyderivationalgorithmnames_pbkdf2sha384.md)
+ [KeyDerivationAlgorithmNames.Pbkdf2Sha512](keyderivationalgorithmnames_pbkdf2sha512.md)


## -examples


[!code-csharp[ShowDerivationFromPbkdf](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowDerivationFromPbkdf)]

## -see-also
