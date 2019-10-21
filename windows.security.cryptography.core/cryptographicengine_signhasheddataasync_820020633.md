---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.SignHashedDataAsync(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> SignHashedDataAsync(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Storage.Streams.IBuffer data)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.SignHashedDataAsync

## -description
Signs the hashed input data using the specified key.

## -parameters
### -param key
The key to use to sign the hash. This key must be an asymmetric key obtained from a [PersistedKeyProvider](persistedkeyprovider.md) or [AsymmetricKeyAlgorithmProvider](asymmetrickeyalgorithmprovider.md).

### -param data
The input data to sign. The data is a hashed value which can be obtained through incremental hash.

## -returns
An asynchronous operation to retrieve the signed data.

## -remarks
<!--<rem  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">If the <mark type="param">key</mark> parameter is a persisted key, user input may be required for a hardware key, strongly protected key, or shared user key.</rem>-->
The input data supplied to the SignHashedDataAsync method is a hashed value. To sign raw data that has not been hashed, use the [SignAsync](cryptographicengine_signasync_345302432.md) method.

If the key is a persisted key and the operation requires UI or takes a long time, use the SignHashedDataAsync method instead of the [SignHashedData](cryptographicengine_signhasheddata_1250888265.md) method.

## -examples

## -see-also
