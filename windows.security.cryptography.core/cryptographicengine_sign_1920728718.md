---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.Sign(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IBuffer Sign(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Storage.Streams.IBuffer data)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.Sign

## -description
Signs digital content. For more information, see [MACs, hashes, and signatures](https://msdn.microsoft.com/library/e674312f-6678-44c5-91d9-b489f49c4d3c).

## -parameters
### -param key
Key used for signing.

### -param data
Data to be signed.

## -returns
The data's signature.

## -remarks
If the key is a persisted key and the operation requires UI or takes a long time, use the [SignAsync](cryptographicengine_signasync_345302432.md) method instead.

For more information about signing digital data, see [MACs, hashes, and signatures](https://msdn.microsoft.com/library/e674312f-6678-44c5-91d9-b489f49c4d3c).

## -examples


[!code-csharp[ShowSigning](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowSigning)]

## -see-also
