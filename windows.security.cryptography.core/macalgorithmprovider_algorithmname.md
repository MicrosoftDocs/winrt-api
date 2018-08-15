---
-api-id: P:Windows.Security.Cryptography.Core.MacAlgorithmProvider.AlgorithmName
-api-type: winrt property
---

<!-- Property syntax
public string AlgorithmName { get; }
-->

# Windows.Security.Cryptography.Core.MacAlgorithmProvider.AlgorithmName

## -description
Gets the name of the open MAC algorithm.

## -property-value
Algorithm name.

## -remarks
You must call the [OpenAlgorithm](macalgorithmprovider_openalgorithm_637226074.md) method before calling this property. The following algorithm names are supported:


+ [MacAlgorithmNames.AesCmac](macalgorithmnames_aescmac.md)
+ [MacAlgorithmNames.HmacMd5](macalgorithmnames_hmacmd5.md)
+ [MacAlgorithmNames.HmacSha1](macalgorithmnames_hmacsha1.md)
+ [MacAlgorithmNames.HmacSha256](macalgorithmnames_hmacsha256.md)
+ [MacAlgorithmNames.HmacSha384](macalgorithmnames_hmacsha384.md)
+ [MacAlgorithmNames.HmacSha512](macalgorithmnames_hmacsha512.md)


## -examples

## -see-also
