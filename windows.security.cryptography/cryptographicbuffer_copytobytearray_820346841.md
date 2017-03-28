---
-api-id: M:Windows.Security.Cryptography.CryptographicBuffer.CopyToByteArray(Windows.Storage.Streams.IBuffer,System.Byte[]@)
-api-type: winrt method
---

<!-- Method syntax
public void CopyToByteArray(Windows.Storage.Streams.IBuffer buffer, System.Byte[] value)
-->

# Windows.Security.Cryptography.CryptographicBuffer.CopyToByteArray

## -description
Copies a buffer to an array of bytes.

## -parameters
### -param buffer
Input buffer.

### -param value
An array of bytes that contains the values copied from the input buffer. You must declare the array before calling this method and pass it by using the **ref** keyword. If the buffer for the *input* parameter is empty, then the *value* parameter will be returned as NULL.

## -remarks

## -examples


[!code-csharp[ShowByteArrayCopy](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowByteArrayCopy)]

## -see-also
