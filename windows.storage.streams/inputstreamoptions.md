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
[DataReader.InputStreamOptions](datareader_inputstreamoptions.md), [FileInputStream.ReadAsync](fileinputstream_readasync_1012630619.md), [FileRandomAccessStream.ReadAsync](filerandomaccessstream_readasync_1012630619.md), [InMemoryRandomAccessStream.ReadAsync](inmemoryrandomaccessstream_readasync_1012630619.md), [InputStreamOverStream.ReadAsync](inputstreamoverstream_readasync_1012630619.md), [RandomAccessStreamOverStream.ReadAsync](randomaccessstreamoverstream_readasync_1012630619.md)