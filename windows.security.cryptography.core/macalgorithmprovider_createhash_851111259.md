---
-api-id: M:Windows.Security.Cryptography.Core.MacAlgorithmProvider.CreateHash(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.CryptographicHash CreateHash(Windows.Storage.Streams.IBuffer keyMaterial)
-->

# Windows.Security.Cryptography.Core.MacAlgorithmProvider.CreateHash

## -description

Creates a [CryptographicHash](cryptographichash.md) object that supports incremental hash operations.

## -parameters

### -param keyMaterial

Random data used to help generate the hash. You can call the [GenerateRandom](../windows.security.cryptography/cryptographicbuffer_generaterandom_1645545930.md) method to create the random data.

## -returns

A [CryptographicHash](cryptographichash.md) object that supports incremental hash operations.

## -remarks

Note that using the same *keyMaterial* will result in the same hashes being produced by the returned **CryptographicHash** for the same input. The *keyMaterial* provided should be known data in order to re-create the hash later.

## -examples

## -see-also

[GenerateRandom](../windows.security.cryptography/cryptographicbuffer_generaterandom_1645545930.md), [CryptographicHash](cryptographichash.md)
