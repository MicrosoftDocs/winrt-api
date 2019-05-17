---
-api-id: T:Windows.Storage.Streams.FileRandomAccessStream
-api-type: winrt class
---

<!-- Class syntax.
public class FileRandomAccessStream : Windows.Foundation.IClosable, Windows.Storage.Streams.IInputStream, Windows.Storage.Streams.IOutputStream, Windows.Storage.Streams.IRandomAccessStream
-->

# Windows.Storage.Streams.FileRandomAccessStream

## -description
Supports reading and writing to a file at a specified position.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | OpenAsync(String,FileAccessMode) |
| 1709 | 16299 | OpenAsync(String,FileAccessMode,StorageOpenOptions,FileOpenDisposition) |
| 1709 | 16299 | OpenForUserAsync(User,String,FileAccessMode) |
| 1709 | 16299 | OpenForUserAsync(User,String,FileAccessMode,StorageOpenOptions,FileOpenDisposition) |
| 1709 | 16299 | OpenTransactedWriteAsync(String) |
| 1709 | 16299 | OpenTransactedWriteAsync(String,StorageOpenOptions,FileOpenDisposition) |
| 1709 | 16299 | OpenTransactedWriteForUserAsync(User,String) |
| 1709 | 16299 | OpenTransactedWriteForUserAsync(User,String,StorageOpenOptions,FileOpenDisposition) |

## -examples

## -see-also
[FileInputStream](fileinputstream.md), [FileOutputStream](fileoutputstream.md), [InMemoryRandomAccessStream](inmemoryrandomaccessstream.md), [RandomAccessStream](randomaccessstream.md)
