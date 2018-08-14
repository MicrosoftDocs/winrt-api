---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.DecryptAndAuthenticate(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IBuffer DecryptAndAuthenticate(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Storage.Streams.IBuffer data, Windows.Storage.Streams.IBuffer nonce, Windows.Storage.Streams.IBuffer authenticationTag, Windows.Storage.Streams.IBuffer authenticatedData)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.DecryptAndAuthenticate

## -description
Decrypts and authenticates data. For more information and a complete code sample, see [EncryptedAndAuthenticatedData](encryptedandauthenticateddata.md).

## -parameters
### -param key
Symmetric key to use.

### -param data
Data to be decrypted and authenticated.

### -param nonce
Nonce to be used. This must be the same nonce used by the [EncryptAndAuthenticate](cryptographicengine_encryptandauthenticate_1818879716.md) method.

### -param authenticationTag
Authentication tag.

### -param authenticatedData
Authenticated data. This can be **Null**.

## -returns
A buffer that contains the decrypted data.If the method fails, authentication fails; if the method succeeds, the authentication succeeded as well.

## -remarks
Authenticated encryption encrypts and authenticates content in one operation. An authenticator, also called a tag, is used during encryption and the output of the process contains a tag-ciphertext pair. For more information, see the [AuthenticationTag](encryptedandauthenticateddata_authenticationtag.md) and [EncryptedData](encryptedandauthenticateddata_encrypteddata.md) properties. The decryption process verifies the ciphertext against the tag.

You can use an authenticated encryption algorithm after calling the [OpenAlgorithm](symmetrickeyalgorithmprovider_openalgorithm_637226074.md) method on the [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md) class and specifying the name of the algorithm to open. The following algorithm names are supported for authenticated encryption and decryption:


+ [SymmetricAlgorithmNames.AesGcm](symmetricalgorithmnames_aesgcm.md)
+ [SymmetricAlgorithmNames.AesCcm](symmetricalgorithmnames_aesccm.md)
For a complete sample that contains the following code example, see the [EncryptedAndAuthenticatedData](encryptedandauthenticateddata.md) class.

## -examples


[!code-csharp[ShowAuthenticatedDecryption](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowAuthenticatedDecryption)]

## -see-also
[EncryptedAndAuthenticatedData](encryptedandauthenticateddata.md)