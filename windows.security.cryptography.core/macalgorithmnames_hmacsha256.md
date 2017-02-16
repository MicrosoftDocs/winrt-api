---
-api-id: P:Windows.Security.Cryptography.Core.MacAlgorithmNames.HmacSha256
-api-type: winrt property
---

<!-- Property syntax
public string HmacSha256 { get; }
-->

# Windows.Security.Cryptography.Core.MacAlgorithmNames.HmacSha256

## -description
Retrieves a string that contains "HMAC_SHA256".

## -property-value
String that contains "HMAC_SHA256".

## -remarks
Use the string retrieved by this property to set the message authentication code (MAC) algorithm name when you call the [OpenAlgorithm](macalgorithmprovider_openalgorithm.md) method. The string represents a hash-based message authentication code (HMAC) algorithm that uses the SHA256 (Secure Hash Algorithm) message digest algorithm to perform the hashing.

## -examples

## -see-also
[MacAlgorithmProvider](macalgorithmprovider.md)