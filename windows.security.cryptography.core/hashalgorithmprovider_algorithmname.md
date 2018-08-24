---
-api-id: P:Windows.Security.Cryptography.Core.HashAlgorithmProvider.AlgorithmName
-api-type: winrt property
---

<!-- Property syntax
public string AlgorithmName { get; }
-->

# Windows.Security.Cryptography.Core.HashAlgorithmProvider.AlgorithmName

## -description
Gets the name of the open hash algorithm.

## -property-value
Algorithm name.

## -remarks
The following hashing algorithm names are supported:


+ [HashAlgorithmNames.Md5](hashalgorithmnames_md5.md)
+ [HashAlgorithmNames.Sha1](hashalgorithmnames_sha1.md)
+ [HashAlgorithmNames.Sha256](hashalgorithmnames_sha256.md)
+ [HashAlgorithmNames.Sha384](hashalgorithmnames_sha384.md)
+ [HashAlgorithmNames.Sha512](hashalgorithmnames_sha512.md)
You must call the [OpenAlgorithm](hashalgorithmprovider_openalgorithm_637226074.md) method before calling this property.

## -examples

## -see-also
[OpenAlgorithm](hashalgorithmprovider_openalgorithm_637226074.md)