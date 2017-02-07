---
-api-id: T:Windows.Storage.Streams.InputStreamOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.Streams.InputStreamOptions : uint
-->

# InputStreamOptions

## -description
Specifies the read options for an input stream.

## -enum-fields
### -field None:0
No options are specified.

### -field Partial:1
The asynchronous read operation completes when one or more bytes is available.

### -field ReadAhead:2
The asynchronous read operation may optionally read ahead and prefetch additional bytes.


## -remarks

## -examples

## -see-also
[DataReader.InputStreamOptions](datareader_inputstreamoptions.md), [FileInputStream.ReadAsync](fileinputstream_readasync.md), [FileRandomAccessStream.ReadAsync](filerandomaccessstream_readasync.md), [InMemoryRandomAccessStream.ReadAsync](inmemoryrandomaccessstream_readasync.md), [InputStreamOverStream.ReadAsync](inputstreamoverstream_readasync.md), [RandomAccessStreamOverStream.ReadAsync](randomaccessstreamoverstream_readasync.md)