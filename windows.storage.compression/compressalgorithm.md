---
-api-id: T:Windows.Storage.Compression.CompressAlgorithm
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.Compression.CompressAlgorithm : int
-->

# CompressAlgorithm

## -description
Identifies a compression algorithm to use when creating an instance of a compressor.

## -enum-fields
### -field InvalidAlgorithm:0
This value represents an invalid compression algorithm. It is useful primarily for error checking.

### -field NullAlgorithm:1
This value represents an algorithm that passes data through with no compression. It is useful primarily for testing.

### -field Mszip:2
The compressor will use the MSZIP compression algorithm.

### -field Xpress:3
The compressor will use the XPRESS compression algorithm.

### -field XpressHuff:4
The compressor will use the XPRESS compression algorithm with Huffman encoding.

### -field Lzms:5
The compressor will use the LZMS compression algorithm.


## -remarks

## -examples

## -see-also