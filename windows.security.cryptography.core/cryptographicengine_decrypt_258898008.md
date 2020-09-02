---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.Decrypt(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IBuffer Decrypt(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Storage.Streams.IBuffer data, Windows.Storage.Streams.IBuffer iv)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.Decrypt

## -description
Decrypts content that was previously encrypted by using a symmetric or asymmetric algorithm.

## -parameters
### -param key
Cryptographic key to use for decryption. This can be an asymmetric or a symmetric key. For more information, see [AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md) and [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md).

### -param data
Buffer that contains the encrypted data.

### -param iv
Buffer that contains the initialization vector. If an initialization vector (IV) was used to encrypt the data, you must use the same IV to decrypt the data. For more information, see [Encrypt](cryptographicengine_encrypt_241662071.md).

## -returns
Decrypted data.

## -remarks
The *key* parameter can be a persisted key obtained from a certificate using the [PersistedKeyProvider](persistedkeyprovider.md) class.

If the key is a persisted key and the decrypt operation requires UI or takes a long time, use the [DecryptAsync](cryptographicengine_decryptasync_155595670.md) method instead. For example, UI is required when decrypting using a key that is strongly protected. In the case where a persisted key is used and UI is expected, use the [DecryptAsync](cryptographicengine_decryptasync_155595670.md) method as the Decrypt method will fail.

## -examples


[!code-csharp[ShowSymmDecryption](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowSymmDecryption)]

## -see-also
[AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md), [Cryptographic keys](/windows/uwp/security/cryptographic-keys), [Encrypt](cryptographicengine_encrypt_241662071.md), [SymmetricKeyAlgorithmProvider](symmetrickeyalgorithmprovider.md)
