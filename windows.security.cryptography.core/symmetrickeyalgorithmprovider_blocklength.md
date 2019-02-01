---
-api-id: P:Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider.BlockLength
-api-type: winrt property
---

<!-- Property syntax
public uint BlockLength { get; }
-->

# Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider.BlockLength

## -description
Gets the size, in bytes, of the cipher block for the open algorithm.

## -property-value
Block size.

## -remarks
If you are not using a PKCS#7 block padding algorithm (which automatically pads your content to the correct length), you must ensure that the message to be encrypted is an exact multiple of the length supported by the algorithm. For more information, see the following code example.

## -examples

## -see-also
[Cryptographic keys](https://msdn.microsoft.com/library/f35bebdf-28c5-4f91-a94e-f7d862b6ed59)
