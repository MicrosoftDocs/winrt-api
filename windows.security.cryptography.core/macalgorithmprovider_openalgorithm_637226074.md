---
-api-id: M:Windows.Security.Cryptography.Core.MacAlgorithmProvider.OpenAlgorithm(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Cryptography.Core.MacAlgorithmProvider OpenAlgorithm(System.String algorithm)
-->

# Windows.Security.Cryptography.Core.MacAlgorithmProvider.OpenAlgorithm

## -description
Creates a [MacAlgorithmProvider](macalgorithmprovider.md) object and opens the specified algorithm for use.

## -parameters
### -param algorithm
Algorithm name.

## -returns
Represents a provider that implements MAC algorithms.

## -remarks
The following algorithm names are supported for use in the [MacAlgorithmProvider](macalgorithmprovider.md) class:


+ [MacAlgorithmNames.AesCmac](macalgorithmnames_aescmac.md)
+ [MacAlgorithmNames.HmacMd5](macalgorithmnames_hmacmd5.md)
+ [MacAlgorithmNames.HmacSha1](macalgorithmnames_hmacsha1.md)
+ [MacAlgorithmNames.HmacSha256](macalgorithmnames_hmacsha256.md)
+ [MacAlgorithmNames.HmacSha384](macalgorithmnames_hmacsha384.md)
+ [MacAlgorithmNames.HmacSha512](macalgorithmnames_hmacsha512.md)


## -examples

## -see-also
