---
-api-id: P:Windows.Security.Cryptography.Core.MacAlgorithmNames.HmacMd5
-api-type: winrt property
---

<!-- Property syntax
public string HmacMd5 { get; }
-->

# Windows.Security.Cryptography.Core.MacAlgorithmNames.HmacMd5

## -description
Retrieves a string that contains "HMAC_MD5".

## -property-value
String that contains "HMAC_MD5".

## -remarks
Use the string retrieved by this property to set the message authentication code (MAC) algorithm name when you call the [OpenAlgorithm](macalgorithmprovider_openalgorithm_637226074.md) method. The string represents a hash-based message authentication code (HMAC) algorithm that uses the MD5 message digest algorithm to perform the hashing.

## -examples

## -see-also
[MacAlgorithmProvider](macalgorithmprovider.md)