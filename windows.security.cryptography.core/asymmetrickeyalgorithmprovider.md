---
-api-id: T:Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider
-api-type: winrt class
---

<!-- Class syntax.
public class AsymmetricKeyAlgorithmProvider : Windows.Security.Cryptography.Core.IAsymmetricKeyAlgorithmProvider, Windows.Security.Cryptography.Core.IAsymmetricKeyAlgorithmProvider2
-->

# Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider

## -description
Represents a provider of asymmetric (public) key algorithms. For more information, see [Cryptographic keys](/windows/uwp/security/cryptographic-keys).

## -remarks
You create an AsymmetricKeyAlgorithmProvider object by calling the static [OpenAlgorithm](asymmetrickeyalgorithmprovider_openalgorithm_637226074.md) method.

## -examples
Because asymmetric cryptography is much slower than symmetric cryptography, it is seldom used to encrypt large amounts of data directly. Instead, it is typically used in the following manner to encrypt keys.


+ Alice requires that Bob send her only encrypted messages.
+ Alice creates a private/public key pair, keeps her private key secret and publishes her public key.
+ Bob has a message he wants to send to Alice.
+ Bob creates a symmetric key.
+ Bob uses his new symmetric key to encrypt his message to Alice.
+ Bob uses Alice's public key to encrypt his symmetric key.
+ Bob sends the encrypted message and the encrypted symmetric key to Alice (enveloped).
+ Alice uses her private key (from the private/public pair) to decrypt Bob’s symmetric key.
+ Alice uses Bob's symmetric key to decrypt the message.
The aspects of the preceding process that can be addressed in code are shown by the following example.



[!code-csharp[ShowAsymmKeyAlgOverview](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowAsymmKeyAlgOverview)]

## -see-also
[CryptographicEngine](cryptographicengine.md), [CryptographicKey](cryptographickey.md), [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)
