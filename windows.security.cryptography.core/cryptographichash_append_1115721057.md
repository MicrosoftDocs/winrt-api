---
-api-id: M:Windows.Security.Cryptography.Core.CryptographicHash.Append(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public void Append(Windows.Storage.Streams.IBuffer data)
-->

# Windows.Security.Cryptography.Core.CryptographicHash.Append

## -description
Appends a binary encoded string to the data stored in the [CryptographicHash](cryptographichash.md) object.

## -parameters
### -param data
Data to append.

## -remarks
Call the [GetValueAndReset](cryptographichash_getvalueandreset_1479544497.md) method to retrieve data from the [CryptographicHash](cryptographichash.md) object and empty the buffer.

## -examples

## -see-also
[CreateHash](hashalgorithmprovider_createhash_203787775.md)