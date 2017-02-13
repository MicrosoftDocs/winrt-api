---
-api-id: P:Windows.Security.Cryptography.Core.MacAlgorithmNames.AesCmac
-api-type: winrt property
---

<!-- Property syntax
public string AesCmac { get; }
-->

# Windows.Security.Cryptography.Core.MacAlgorithmNames.AesCmac

## -description
Retrieves a string that contains "AES_CMAC".

## -property-value
String that contains "AesCmac".

## -remarks
Use the string retrieved by this property to set the message authentication code (MAC) algorithm name when you call the [OpenAlgorithm](macalgorithmprovider_openalgorithm.md) method. The string represents an Advanced Encryption Standard (AES) encryption algorithm coupled with a cipher-based MAC block cipher algorithm. For more information, see RFC 4493.

## -examples

## -see-also
[MacAlgorithmProvider](macalgorithmprovider.md)