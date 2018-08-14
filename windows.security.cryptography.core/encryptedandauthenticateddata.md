---
-api-id: T:Windows.Security.Cryptography.Core.EncryptedAndAuthenticatedData
-api-type: winrt class
---

<!-- Class syntax.
public class EncryptedAndAuthenticatedData : Windows.Security.Cryptography.Core.IEncryptedAndAuthenticatedData
-->

# Windows.Security.Cryptography.Core.EncryptedAndAuthenticatedData

## -description
Contains data that can be retrieved from encrypted and authenticated data. Authenticated encryption algorithms are opened by using the [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) class.

## -remarks
Authenticated encryption encrypts and authenticates content in one operation. An authenticator, also called a tag, is used during encryption and the output of the process contains a tag-ciphertext pair. For more information, see the [AuthenticationTag](encryptedandauthenticateddata_authenticationtag.md) and [EncryptedData](encryptedandauthenticateddata_encrypteddata.md) properties. The decryption process verifies the ciphertext against the tag.

You can use an authenticated encryption algorithm after calling the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm_637226074.md) method on the [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) class and specifying the name of the algorithm to open. The following algorithm names are supported for authenticated encryption and decryption:


+ AES_GCM
+ AES_CCM


## -examples


[!code-csharp[ShowEncryptedAuthenticatedDataClass](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowEncryptedAuthenticatedDataClass)]

## -see-also
[CryptographicEngine](cryptographicengine.md), [DecryptAndAuthenticate](cryptographicengine_decryptandauthenticate_1380391671.md), [EncryptAndAuthenticate](cryptographicengine_encryptandauthenticate_1818879716.md), [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)