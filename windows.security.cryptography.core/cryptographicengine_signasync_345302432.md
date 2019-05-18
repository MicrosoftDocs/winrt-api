---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicEngine.SignAsync(Windows.Security.Cryptography.Core.CryptographicKey,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> SignAsync(Windows.Security.Cryptography.Core.CryptographicKey key, Windows.Storage.Streams.IBuffer data)
-->

# Windows.Security.Cryptography.Core.CryptographicEngine.SignAsync

## -description
Computes a hash for the supplied input data, and then signs the computed hash using the specified key.

## -parameters
### -param key
The key to use to compute and sign the hash.

### -param data
The raw input data to sign. The data is not hashed.

## -returns
An asynchronous operation to retrieve the hashed and signed data.

## -remarks
<!--<rem  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">If the <mark type="param">key</mark> parameter is a persisted key, user input may be required for a hardware key, strongly protected key, or shared user key.</rem>-->
The input data supplied to the SignAsync method is raw data that has not been hashed. To sign hashed data, use the [SignHashedDataAsync](cryptographicengine_signhasheddataasync_820020633.md) method.

If the key is a persisted key and the operation requires UI or takes a long time, use the SignAsync method instead of the [Sign](cryptographicengine_sign_1920728718.md) method.



## -examples

## -see-also
