---
-api-id: M:Windows.Security.Cryptography.CryptographicBuffer.Compare(Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public bool Compare(Windows.Storage.Streams.IBuffer object1, Windows.Storage.Streams.IBuffer object2)
-->

# Windows.Security.Cryptography.CryptographicBuffer.Compare

## -description
Compares two [IBuffer](../windows.storage.streams/ibuffer.md) objects.

## -parameters
### -param object1
Buffer to be used for comparison.

### -param object2
Buffer to be used for comparison.

## -returns
**True** specifies that the buffers are equal. Two buffers are equal if each code point in one matches the corresponding code point in the other.

## -remarks

## -examples


[!code-csharp[ShowBufferCompare](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowBufferCompare)]

## -see-also
