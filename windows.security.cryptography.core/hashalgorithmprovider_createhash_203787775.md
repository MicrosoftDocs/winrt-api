---
-api-id: M:Windows.Security.Cryptography.Core.HashAlgorithmProvider.CreateHash
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.CryptographicHash CreateHash()
-->

# Windows.Security.Cryptography.Core.HashAlgorithmProvider.CreateHash

## -description
Creates a reusable [CryptographicHash](cryptographichash.md) object.

## -returns
Reusable hash object.

## -remarks
You must call the [OpenAlgorithm](hashalgorithmprovider_openalgorithm.md) method before calling this property. Call the [Append](cryptographichash_append.md) method on the [CryptographicHash](cryptographichash.md) object to copy hashed data into a buffer. Call the [GetValueAndReset](cryptographichash_getvalueandreset.md) method to retrieve the hashed data and reset the [CryptographicHash](cryptographichash.md) object so that it can be used again to hash more data.

## -examples

## -see-also
[CryptographicHash](cryptographichash.md)