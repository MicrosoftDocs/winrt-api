---
-api-id: T:Windows.Security.Cryptography.Core.CryptographicKey
-api-type: winrt class
---

<!-- Class syntax.
public class CryptographicKey : Windows.Security.Cryptography.Core.ICryptographicKey
-->

# Windows.Security.Cryptography.Core.CryptographicKey

## -description
Represents a symmetric key or an asymmetric key pair.

## -remarks

A [CryptographicKey](cryptographickey.md) object is created when you use methods that create or import keys in the following classes:

+ [AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md)
+ [KeyDerivationAlgorithmProvider](keyderivationalgorithmprovider.md)
+ [MacAlgorithmProvider](macalgorithmprovider.md)
+ [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)


## -examples


[!code-csharp[ShowCryptographicKeyClass](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowCryptographicKeyClass)]

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md), [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)