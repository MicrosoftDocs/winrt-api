---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.DecryptAsync(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> DecryptAsync(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Storage.Streams.IBuffer data, Windows.Storage.Streams.IBuffer iv)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.DecryptAsync

## -description
Decrypts the encrypted input data using the supplied key.

## -parameters
### -param key
The key to use to decrypt the encrypted input data.

### -param data
The encrypted data to decrypt.

### -param iv
The initial vector for a symmetric key. For an asymmetric key, set this value to null.

## -returns
The decrypted data.

## -remarks
If the key is a persisted key and the decrypt operation requires UI or takes a long time, use the DecryptAsync method instead of the [Decrypt](cryptographicengine_decrypt_258898008.md) method. For example, UI is required when decrypting using a key that is strongly protected.

## -examples

## -see-also
