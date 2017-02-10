---
-api-id: M:Windows.Storage.Compression.Compressor.#ctor(Windows.Storage.Streams.IOutputStream,Windows.Storage.Compression.CompressAlgorithm,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Compressor(Windows.Storage.Streams.IOutputStream underlyingStream, Windows.Storage.Compression.CompressAlgorithm algorithm, System.UInt32 blockSize)
-->

# Windows.Storage.Compression.Compressor.Compressor

## -description
Creates an instance of a compressor.

## -parameters
### -param underlyingStream
The stream of compressed information to be written by the compressor.

### -param algorithm
The compression algorithm used by the compressor to write *underlyingStream*.

### -param blockSize
Size in bytes of the intermediate buffer used by the compression algorithm. A value of 0 specifies that the compression algorithm will use its default block size. Valid non-zero values for this parameter are 32Kb to 64Mb.

## -remarks

## -examples

## -see-also
[Compressor(IOutputStream)](compressor_compressor_1377225267.md)