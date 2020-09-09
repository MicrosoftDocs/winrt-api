---
-api-id: T:Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider
-api-type: winrt class
---

<!-- Class syntax.
public class SymmetricKeyAlgorithmProvider : Windows.Security.Cryptography.Core.ISymmetricKeyAlgorithmProvider
-->

# Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider

## -description
Represents a provider of symmetric key algorithms. For more information, see [Cryptographic keys](/windows/uwp/security/cryptographic-keys).

## -remarks
You create a SymmetricKeyAlgorithmProvider object by calling the static [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm_637226074.md) method and specifying one of the following algorithm names.


+ No padding:+ DES_CBC
+ DES_ECB
+ 3DES_CBC
+ 3DES_ECB
+ RC2_CBC
+ RC2_ECB
+ AES_CBC
+ AES_ECB

+ PKCS#7 block padding modes:+ AES_CBC_PKCS7
+ AES_ECB_PKCS7
+ DES_CBC_PKCS7
+ DES_ECB_PKCS7
+ 3DES_CBC_PKCS7
+ 3DES_ECB_PKCS7
+ RC2_CBC_PKCS7
+ RC2_ECB_PKCS7

+ Authenticated modes (see the [EncryptedAndAuthenticatedData](encryptedandauthenticateddata.md) class):+ AES_GCM
+ AES_CCM

+ Stream Cipher:+ RC4



## -examples


[!code-csharp[ShowSymmKeyAlgProviderClass](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowSymmKeyAlgProviderClass)]


## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md), [CryptographicEngine](cryptographicengine.md), [CryptographicKey](cryptographickey.md)
