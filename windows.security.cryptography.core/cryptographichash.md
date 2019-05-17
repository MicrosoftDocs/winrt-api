---
-api-id: T:Windows.Security.Cryptography.Core.CryptographicHash
-api-type: winrt class
---

<!-- Class syntax.
public class CryptographicHash : Windows.Security.Cryptography.Core.IHashComputation
-->

# Windows.Security.Cryptography.Core.CryptographicHash

## -description
Represents a reusable hashing object and contains the result of a hashing operation.

## -remarks
Call the [HashAlgorithmProvider.CreateHash](hashalgorithmprovider_createhash_203787775.md) or [MacAlgorithmProvider.CreateHash](macalgorithmprovider_createhash_851111259.md) method to create a CryptographicHash object. You can open a hash algorithm provider, by name, for any of the following algorithm names:


+ MD5
+ SHA1
+ SHA256
+ SHA384
+ SHA512


## -examples


[!code-csharp[ShowAppend](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowAppend)]

## -see-also
[HashAlgorithmProvider](hashalgorithmprovider.md), [CreateHash](hashalgorithmprovider_createhash_203787775.md)
