---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.VerifySignature(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public bool VerifySignature(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Storage.Streams.IBuffer data, Windows.Storage.Streams.IBuffer signature)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.VerifySignature

## -description
Verifies a message signature.

## -parameters
### -param key
Key used for verification. This must be the same key previously used to sign the message.

### -param data
Message to be verified.

### -param signature
Signature previously computed over the message to be verified.

## -returns
**true** if the message is verified.

## -remarks
To sign content, the sender typically creates a hash over the message, signs (encrypts) the hash, and then sends both the signature and the unencrypted message. The recipient uses the same key and algorithm to calculate a hash over the message, decrypts the signature, and compares the decrypted signature to the hash value. If they match, the recipient can be fairly certain that the message did, in fact, come from the sender and was not altered during transmission. For more information, see [MACs, hashes, and signatures](/windows/uwp/security/macs-hashes-and-signatures).

## -examples


[!code-csharp[ShowVerifySignature](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowVerifySignature)]

## -see-also
