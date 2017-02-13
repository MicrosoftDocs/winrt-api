---
-api-id: M:Windows.Storage.IStorageFile2.OpenAsync(Windows.Storage.FileAccessMode,Windows.Storage.StorageOpenOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStream> OpenAsync(Windows.Storage.FileAccessMode accessMode, Windows.Storage.StorageOpenOptions options)
-->

# Windows.Storage.IStorageFile2.OpenAsync

## -description
Opens a random-access stream over the file.

## -parameters
### -param accessMode
One of the enumeration values that specifies the type of access to allow.

### -param options
A bitwise combination of the enumeration values that specify options for opening the stream.

## -returns
When this method completes, it returns an [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) that contains the requested random-access stream.

## -remarks
If you simply want to open a file in your app, see the [OpenAsync](storagefile_openasync.md) method of the [StorageFile](storagefile.md) class.

Using this method, a file can be accessed by both file readers and writers simultaneously. The following is a table describing the situations for various parameter settings of [FileAccessMode](fileaccessmode.md) and [StorageOpenOptions](storageopenoptions.md):

|                        | FileAccessMode | |
|------------------------|------|-----------|
| **StorageOpenOptions** | Read | ReadWrite |
| None                   | A reader which is lower priority than a writer. If a write occurs, this low priority reader will fail. | This is a single writer. The file cannot be opened if OpenAsync(Read, AllowOnlyReaders) has been used, and it will prevent a new OpenAsync(Read, AllowOnlyReaders) from being used. |
| AllowOnlyReaders       | A reader which can only exist with other readers. If an open is attempted with a writer, it will fail. | This is a single writer. The file cannot be opened if OpenAsync(Read, AllowOnlyReaders) has been used, and it will prevent a new OpenAsync(Read, AllowOnlyReaders) from being used. |
| AllowReadersAndWriters | A reader which can exist with other readers and writers simultaneously. | This writer will invalidate low priority readers when a write occurs and can coexist with other readers and writers. |


## -examples

## -see-also
